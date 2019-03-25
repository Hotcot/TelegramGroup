
using static System.Math;
using static System.Console;

namespace ConsoleBd
{
    class Network
    {

        //все слои сети
        InputLayer input_layer = new InputLayer();// происходит инициализация

        public HiddenLayer hidden_layer = new HiddenLayer(10, 211, NeuronType.Hidden, "hidden");
        public HiddenLayer hidden_layer2 = new HiddenLayer(10, 10, NeuronType.Hidden, "hidden2");
        public HiddenLayer hidden_layer3 = new HiddenLayer(10, 10, NeuronType.Hidden, "hidden3");
        public HiddenLayer hidden_layer4 = new HiddenLayer(10, 10, NeuronType.Hidden, "hidden4");
        public HiddenLayer hidden_layer5 = new HiddenLayer(10, 10, NeuronType.Hidden, "hidden5");
        public HiddenLayer hidden_layer6 = new HiddenLayer(10, 10, NeuronType.Hidden, "hidden6");
        public HiddenLayer hidden_layer7 = new HiddenLayer(10, 10, NeuronType.Hidden, "hidden7");
        public OutputLayer output_layer = new OutputLayer(7, 10, NeuronType.Output, "output");
        //массив для хранения выхода сети
        public double[] fact = new double[7];//не ругайте за 2 пожалуйста
        //ошибка одной итерации обучения
        double GetMSE(double[] errors)
        {
            double sum = 0;
            for (int i = 0; i < errors.Length; ++i)
                sum += Pow(errors[i], 2);
            return 0.5d * sum;
        }
        //ошибка эпохи
        double GetCost(double[] mses)
        {
            double sum = 0;
            for (int i = 0; i < mses.Length; ++i)
                sum += mses[i];
            return (sum / mses.Length);
        }

        //непосредственно обучение
        public static void Train(Network net)//backpropagation method
        {
            const double threshold = 0.001d;//порог ошибки
            double[] temp_mses = new double[7];//массив для хранения ошибок итераций
            double temp_cost = 0;//текущее значение ошибки по эпохе    

            do
            {
                for (int i = 0; i < net.input_layer.Trainset.Length; ++i)
                {
                    //прямой проход
                    net.hidden_layer.Data = net.input_layer.Trainset[i].Item1;
                    net.hidden_layer.Recognize(null, net.output_layer);
                    net.output_layer.Recognize(net, null);
                    //вычисление ошибки по итерации
                    double[] errors = new double[net.input_layer.Trainset[i].Item2.Length];
                    for (int x = 0; x < errors.Length; ++x)
                        errors[x] = net.input_layer.Trainset[i].Item2[x] - net.fact[x];
                    temp_mses[i] = net.GetMSE(errors);
                    //обратный проход и коррекция весов
                    double[] temp_gsums = net.output_layer.BackwardPass(errors);
                    net.hidden_layer.BackwardPass(temp_gsums);
                }
                temp_cost = net.GetCost(temp_mses);//вычисление ошибки по эпохе
                //debugging
                WriteLine($"{temp_cost}");
            } while (temp_cost > threshold);
            //загрузка скорректированных весов в "память"
            net.hidden_layer.WeightInitialize(MemoryMode.SET, "hidden");
            net.hidden_layer2.WeightInitialize(MemoryMode.SET, "hidden2");
            net.hidden_layer3.WeightInitialize(MemoryMode.SET, "hidden3");
            net.hidden_layer4.WeightInitialize(MemoryMode.SET, "hidden4");
            net.hidden_layer5.WeightInitialize(MemoryMode.SET, "hidden5");
            net.hidden_layer6.WeightInitialize(MemoryMode.SET, "hidden6");
            net.hidden_layer7.WeightInitialize(MemoryMode.SET, "hidden7");
            net.output_layer.WeightInitialize(MemoryMode.SET, "output");
        }
        //тестирование сети
        public static void Test(Network net)
        {
            for (int i = 0; i < net.input_layer.Trainset.Length; ++i)
            {
                net.hidden_layer.Data = net.input_layer.Trainset[i].Item1;
                net.hidden_layer.Recognize(null, net.output_layer);
                net.output_layer.Recognize(net, null);
                for (int j = 0; j < net.fact.Length; ++j)
                    WriteLine($"{net.fact[j]}");
                WriteLine();
            }
        }
    }
}
