﻿

namespace ConsoleBd
{
    class InputLayer
    {
        private (double[], double[])[] _trainset = new (double[], double[])[]//да-да, массив кортежей из 2 массивов
      {
            (new double[]{0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0 ,0}, new double[]{ 0, 0, 0, 0, 0, 0, 1 }),
            (new double[]{1,1,1,1,1,1,1,1,1,1  ,1,1,1,1,1,1,1,1,1,1  ,1,1,1,1,1,1,1,1,1,1  ,1,1,1,1,1,1,1,1,1,1  ,1,1,1,1,1,1,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0 ,0}, new double[]{ 1, 0, 0, 0, 0, 0, 0 }),
            (new double[]{0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,1,1,1,1  ,1,1,1,1,1,1,1,1,1,1  ,1,1,1,1,1,1,1,1,1,1  ,1,1,1,1,1,1,1,1,1,1  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0 ,0}, new double[]{ 0, 1, 0, 0, 0, 0, 0 }),
            (new double[]{0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,1,1,1,1,1,1,1,1,1,1  ,1,1,1,1,1,1,1,1,1,1  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0 ,0}, new double[]{ 0, 0, 1, 0, 0, 0, 0 }),
            (new double[]{0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,1,1,1,1,1,1,1,1,1,1  ,1,1,1,1,1,1,1,1,1,1  ,1,1,1,1,1,1,1,1,1,1  ,1,1,1,1,1,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0 ,0}, new double[]{ 0, 0, 0, 1, 0, 0, 0 }),
            (new double[]{0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,1,1,1,1,1  ,1,1,1,1,1,1,1,1,1,1  ,1,1,1,1,1,1,1,1,1,1  ,1,1,1,1,1,1,1,1,1,1  ,1,1,1,1,1,1,1,1,1,1  ,1,1,1,1,1,1,1,1,1,1  ,1,1,1,1,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0 ,0}, new double[]{ 0, 0, 0, 0, 1, 0, 0 }),
            (new double[]{0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,0,0,0,0,0,0  ,0,0,0,0,1,1,1,1,1,1  ,1,1,1,1,1,1,1,1,1,1 ,1}, new double[]{ 0, 0, 0, 0, 0, 1, 0 }),


      };

        //инкапсуляция едрид-мадрид
        public (double[], double[])[] Trainset { get => _trainset; }//такие няшные свойства нынче в C# 7
    }
}
