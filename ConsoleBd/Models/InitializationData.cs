
using System.Data.Entity;

namespace ConsoleBd
{
    class InitializationData : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext db)
        {

            IndificatorData lecs1 = new IndificatorData { IndificTeg = "бизнес" };
            IndificatorData lecs2 = new IndificatorData { IndificTeg = "рынок" };
            IndificatorData lecs3 = new IndificatorData { IndificTeg = "фондовый" };
            IndificatorData lecs4 = new IndificatorData { IndificTeg = "доходы" };
            IndificatorData lecs5 = new IndificatorData { IndificTeg = "компания" };
            IndificatorData lecs6 = new IndificatorData { IndificTeg = "корпорация" };
            IndificatorData lecs7 = new IndificatorData { IndificTeg = "контракт" };
            IndificatorData lecs8 = new IndificatorData { IndificTeg = "договор" };
            IndificatorData lecs9 = new IndificatorData { IndificTeg = "директор" };
            IndificatorData lecs10 = new IndificatorData { IndificTeg = "сотрудник" };

            IndificatorData lecs11 = new IndificatorData { IndificTeg = "цена" };
            IndificatorData lecs12 = new IndificatorData { IndificTeg = "нефть" };
            IndificatorData lecs13 = new IndificatorData { IndificTeg = "электричество" };
            IndificatorData lecs14 = new IndificatorData { IndificTeg = "фьючерс" };
            IndificatorData lecs15 = new IndificatorData { IndificTeg = "биржа" };
            IndificatorData lecs16 = new IndificatorData { IndificTeg = "биржа" };
            IndificatorData lecs17 = new IndificatorData { IndificTeg = "баррель" };
            IndificatorData lecs18 = new IndificatorData { IndificTeg = "товар" };
            IndificatorData lecs19 = new IndificatorData { IndificTeg = "добыча" };
            IndificatorData lecs20 = new IndificatorData { IndificTeg = "доллар" };

            IndificatorData lecs21 = new IndificatorData { IndificTeg = "производство" };
            IndificatorData lecs22 = new IndificatorData { IndificTeg = "аналитика" };
            IndificatorData lecs23 = new IndificatorData { IndificTeg = "снижение" };
            IndificatorData lecs24 = new IndificatorData { IndificTeg = "повышение" };
            IndificatorData lecs25 = new IndificatorData { IndificTeg = "индексы" };
            IndificatorData lecs26 = new IndificatorData { IndificTeg = "подешевел" };
            IndificatorData lecs27 = new IndificatorData { IndificTeg = "подорожал" };
            IndificatorData lecs28 = new IndificatorData { IndificTeg = "евро" };
            IndificatorData lecs29 = new IndificatorData { IndificTeg = "доход" };
            IndificatorData lecs30 = new IndificatorData { IndificTeg = "производитель" };

            IndificatorData lecs31 = new IndificatorData { IndificTeg = "forbes" };
            IndificatorData lecs32 = new IndificatorData { IndificTeg = "рейтинг" };
            IndificatorData lecs33 = new IndificatorData { IndificTeg = "владелец" };
            IndificatorData lecs34 = new IndificatorData { IndificTeg = "маркетинг брэндинг" };
            IndificatorData lecs35 = new IndificatorData { IndificTeg = "состояние" };
            IndificatorData lecs36 = new IndificatorData { IndificTeg = "сделка" };
            IndificatorData lecs37 = new IndificatorData { IndificTeg = "санкции" };
            IndificatorData lecs38 = new IndificatorData { IndificTeg = "инвестор" };
            IndificatorData lecs39 = new IndificatorData { IndificTeg = "стартап" };
            IndificatorData lecs40 = new IndificatorData { IndificTeg = "проект" };

            IndificatorData lecs41 = new IndificatorData { IndificTeg = "франшиза" };
            IndificatorData lecs42 = new IndificatorData { IndificTeg = "инвестиция" };
            IndificatorData lecs43 = new IndificatorData { IndificTeg = "недвижемость" };
            IndificatorData lecs44 = new IndificatorData { IndificTeg = "доход" };
            IndificatorData lecs45 = new IndificatorData { IndificTeg = "офшор" };
            IndificatorData lecs46 = new IndificatorData { IndificTeg = "бренд" };
            IndificatorData lecs47 = new IndificatorData { IndificTeg = "здоровье" };
            IndificatorData lecs48 = new IndificatorData { IndificTeg = "онкология" };
            IndificatorData lecs49 = new IndificatorData { IndificTeg = "стресс" };
            IndificatorData lecs50 = new IndificatorData { IndificTeg = "болезни" };

            IndificatorData lecs51 = new IndificatorData { IndificTeg = "эмоции" };
            IndificatorData lecs52 = new IndificatorData { IndificTeg = "еда" };
            IndificatorData lecs53 = new IndificatorData { IndificTeg = "медицина" };
            IndificatorData lecs54 = new IndificatorData { IndificTeg = "природа" };
            IndificatorData lecs55 = new IndificatorData { IndificTeg = "витамины" };
            IndificatorData lecs56 = new IndificatorData { IndificTeg = "вода" };
            IndificatorData lecs57 = new IndificatorData { IndificTeg = "врач" };
            IndificatorData lecs58 = new IndificatorData { IndificTeg = "травы" };
            IndificatorData lecs59 = new IndificatorData { IndificTeg = "йога" };
            IndificatorData lecs60 = new IndificatorData { IndificTeg = "тело" };

            IndificatorData lecs61 = new IndificatorData { IndificTeg = "жизнь" };
            IndificatorData lecs62 = new IndificatorData { IndificTeg = "химия" };
            IndificatorData lecs63 = new IndificatorData { IndificTeg = "лекарства" };
            IndificatorData lecs64 = new IndificatorData { IndificTeg = "жир" };
            IndificatorData lecs65 = new IndificatorData { IndificTeg = "альтернативная" };
            IndificatorData lecs66 = new IndificatorData { IndificTeg = "мозг" };
            IndificatorData lecs67 = new IndificatorData { IndificTeg = "кишечник" };
            IndificatorData lecs68 = new IndificatorData { IndificTeg = "желудок" };
            IndificatorData lecs69 = new IndificatorData { IndificTeg = "кости" };
            IndificatorData lecs70 = new IndificatorData { IndificTeg = "суставы" };

            IndificatorData lecs71 = new IndificatorData { IndificTeg = "кровеноснаясистема" };
            IndificatorData lecs72 = new IndificatorData { IndificTeg = "вены" };
            IndificatorData lecs73 = new IndificatorData { IndificTeg = "капилляры" };
            IndificatorData lecs74 = new IndificatorData { IndificTeg = "глаза" };
            IndificatorData lecs75 = new IndificatorData { IndificTeg = "уши" };
            IndificatorData lecs76 = new IndificatorData { IndificTeg = "нос" };
            IndificatorData lecs77 = new IndificatorData { IndificTeg = "бактерии" };
            IndificatorData lecs78 = new IndificatorData { IndificTeg = "вирусы" };
            IndificatorData lecs79 = new IndificatorData { IndificTeg = "факты" };
            IndificatorData lecs80 = new IndificatorData { IndificTeg = "наука" };

            IndificatorData lecs81 = new IndificatorData { IndificTeg = "открытие" };
            IndificatorData lecs82 = new IndificatorData { IndificTeg = "исследование" };
            IndificatorData lecs83 = new IndificatorData { IndificTeg = "математика" };
            IndificatorData lecs84 = new IndificatorData { IndificTeg = "химия" };
            IndificatorData lecs85 = new IndificatorData { IndificTeg = "физика" };
            IndificatorData lecs86 = new IndificatorData { IndificTeg = "строфизика" };
            IndificatorData lecs87 = new IndificatorData { IndificTeg = "биология" };
            IndificatorData lecs88 = new IndificatorData { IndificTeg = "археология" };
            IndificatorData lecs89 = new IndificatorData { IndificTeg = "ученый" };
            IndificatorData lecs90 = new IndificatorData { IndificTeg = "выставка" };

            IndificatorData lecs91 = new IndificatorData { IndificTeg = "палеозоология" };
            IndificatorData lecs92 = new IndificatorData { IndificTeg = "астрономия" };
            IndificatorData lecs93 = new IndificatorData { IndificTeg = "футурология" };
            IndificatorData lecs94 = new IndificatorData { IndificTeg = "NASA" };
            IndificatorData lecs95 = new IndificatorData { IndificTeg = "космос" };
            IndificatorData lecs96 = new IndificatorData { IndificTeg = "артефакт" };
            IndificatorData lecs97 = new IndificatorData { IndificTeg = "доказательства" };
            IndificatorData lecs98 = new IndificatorData { IndificTeg = "космос" };
            IndificatorData lecs99 = new IndificatorData { IndificTeg = "госслужащий" };
            IndificatorData lecs100 = new IndificatorData { IndificTeg = "галактика" };

            IndificatorData lecs101 = new IndificatorData { IndificTeg = "политика" };
            IndificatorData lecs102 = new IndificatorData { IndificTeg = "президент" };
            IndificatorData lecs103 = new IndificatorData { IndificTeg = "премьер" };
            IndificatorData lecs104 = new IndificatorData { IndificTeg = "держава" };
            IndificatorData lecs105 = new IndificatorData { IndificTeg = "госслужащий" };
            IndificatorData lecs106 = new IndificatorData { IndificTeg = "конфликт" };
            IndificatorData lecs107 = new IndificatorData { IndificTeg = "агрессия" };
            IndificatorData lecs108 = new IndificatorData { IndificTeg = "выборы" };
            IndificatorData lecs109 = new IndificatorData { IndificTeg = "митинги" };
            IndificatorData lecs110 = new IndificatorData { IndificTeg = "протесты" };

            IndificatorData lecs111 = new IndificatorData { IndificTeg = "марш" };
            IndificatorData lecs112 = new IndificatorData { IndificTeg = "война" };
            IndificatorData lecs113 = new IndificatorData { IndificTeg = "первое" };
            IndificatorData lecs114 = new IndificatorData { IndificTeg = "лицо" };
            IndificatorData lecs115 = new IndificatorData { IndificTeg = "нарушения" };
            IndificatorData lecs116 = new IndificatorData { IndificTeg = "конвенции" };
            IndificatorData lecs117 = new IndificatorData { IndificTeg = "кандидат" };
            IndificatorData lecs118 = new IndificatorData { IndificTeg = "агрессор" };
            IndificatorData lecs119 = new IndificatorData { IndificTeg = "миротворец" };
            IndificatorData lecs120 = new IndificatorData { IndificTeg = "встреча" };

            IndificatorData lecs121 = new IndificatorData { IndificTeg = "соглашение" };
            IndificatorData lecs122 = new IndificatorData { IndificTeg = "мир" };
            IndificatorData lecs123 = new IndificatorData { IndificTeg = "договор" };
            IndificatorData lecs124 = new IndificatorData { IndificTeg = "санкции" };
            IndificatorData lecs125 = new IndificatorData { IndificTeg = "эмбарго" };
            IndificatorData lecs126 = new IndificatorData { IndificTeg = "демократия" };
            IndificatorData lecs127 = new IndificatorData { IndificTeg = "нарушения" };
            IndificatorData lecs128 = new IndificatorData { IndificTeg = "монархия" };
            IndificatorData lecs129 = new IndificatorData { IndificTeg = "король" };
            IndificatorData lecs130 = new IndificatorData { IndificTeg = "император" };

            IndificatorData lecs131 = new IndificatorData { IndificTeg = "диктатор" };
            IndificatorData lecs132 = new IndificatorData { IndificTeg = "власть" };
            IndificatorData lecs133 = new IndificatorData { IndificTeg = "посол" };
            IndificatorData lecs134 = new IndificatorData { IndificTeg = "спорт" };
            IndificatorData lecs135 = new IndificatorData { IndificTeg = "олимпийские" };
            IndificatorData lecs136 = new IndificatorData { IndificTeg = "академическаягребля" };
            IndificatorData lecs137 = new IndificatorData { IndificTeg = "бадминтон" };
            IndificatorData lecs138 = new IndificatorData { IndificTeg = "баскетбол" };
            IndificatorData lecs139 = new IndificatorData { IndificTeg = "бокс" };
            IndificatorData lecs140 = new IndificatorData { IndificTeg = "борьба" };

            IndificatorData lecs141 = new IndificatorData { IndificTeg = "вольнаяборьба" };
            IndificatorData lecs142 = new IndificatorData { IndificTeg = "греко-римскаяборьба" };
            IndificatorData lecs143 = new IndificatorData { IndificTeg = "велоспорт" };
            IndificatorData lecs144 = new IndificatorData { IndificTeg = "трековыйвелоспорт" };
            IndificatorData lecs145 = new IndificatorData { IndificTeg = "маунтинбайк" };
            IndificatorData lecs146 = new IndificatorData { IndificTeg = "водныевидыспорта" };
            IndificatorData lecs147 = new IndificatorData { IndificTeg = "водноеполо" };
            IndificatorData lecs148 = new IndificatorData { IndificTeg = "плавание" };
            IndificatorData lecs149 = new IndificatorData { IndificTeg = "прыжкивводу" };
            IndificatorData lecs150 = new IndificatorData { IndificTeg = "синхронноеплавание" };

            IndificatorData lecs151 = new IndificatorData { IndificTeg = "плаванье" };
            IndificatorData lecs152 = new IndificatorData { IndificTeg = "марафон" };
            IndificatorData lecs153 = new IndificatorData { IndificTeg = "волейбол" };
            IndificatorData lecs154 = new IndificatorData { IndificTeg = "пляжныйволейбол" };
            IndificatorData lecs155 = new IndificatorData { IndificTeg = "гандбол" };
            IndificatorData lecs156 = new IndificatorData { IndificTeg = "гимнастика" };
            IndificatorData lecs157 = new IndificatorData { IndificTeg = "гольф" };
            IndificatorData lecs158 = new IndificatorData { IndificTeg = "греблянабайдаркахиканоэ" };
            IndificatorData lecs159 = new IndificatorData { IndificTeg = "гребнойслаломдзюдо" };
            IndificatorData lecs160 = new IndificatorData { IndificTeg = "конныйспорт" };

            IndificatorData lecs161 = new IndificatorData { IndificTeg = "выездка" };
            IndificatorData lecs162 = new IndificatorData { IndificTeg = "конкур" };
            IndificatorData lecs163 = new IndificatorData { IndificTeg = "троеборье" };
            IndificatorData lecs164 = new IndificatorData { IndificTeg = "современноепятиборье" };
            IndificatorData lecs165 = new IndificatorData { IndificTeg = "стрельба" };
            IndificatorData lecs166 = new IndificatorData { IndificTeg = "стрельбаизлука" };
            IndificatorData lecs167 = new IndificatorData { IndificTeg = "теннис" };
            IndificatorData lecs168 = new IndificatorData { IndificTeg = "триатлон" };
            IndificatorData lecs169 = new IndificatorData { IndificTeg = "тхэквондо" };
            IndificatorData lecs170 = new IndificatorData { IndificTeg = "тяжёлаяатлетика" };

            IndificatorData lecs171 = new IndificatorData { IndificTeg = "фехтование" };
            IndificatorData lecs172 = new IndificatorData { IndificTeg = "футбол" };
            IndificatorData lecs173 = new IndificatorData { IndificTeg = "хоккейнатраве" };
            IndificatorData lecs174 = new IndificatorData { IndificTeg = "велоспорт" };
            IndificatorData lecs175 = new IndificatorData { IndificTeg = "BMX-фристайл" };
            IndificatorData lecs176 = new IndificatorData { IndificTeg = "бейсбол/софтбол" };
            IndificatorData lecs177 = new IndificatorData { IndificTeg = "бейсбол" };
            IndificatorData lecs178 = new IndificatorData { IndificTeg = "софтбол" };
            IndificatorData lecs179 = new IndificatorData { IndificTeg = "спортивноескалолазание" };
            IndificatorData lecs180 = new IndificatorData { IndificTeg = "карате" };

            IndificatorData lecs181 = new IndificatorData { IndificTeg = "скейтбординг" };
            IndificatorData lecs182 = new IndificatorData { IndificTeg = "сёрфинг" };
            IndificatorData lecs183 = new IndificatorData { IndificTeg = "технологии" };
            IndificatorData lecs184 = new IndificatorData { IndificTeg = "ит" };
            IndificatorData lecs185 = new IndificatorData { IndificTeg = "компьютер" };
            IndificatorData lecs186 = new IndificatorData { IndificTeg = "программист" };
            IndificatorData lecs187 = new IndificatorData { IndificTeg = "изобретение" };
            IndificatorData lecs188 = new IndificatorData { IndificTeg = "разработка" };
            IndificatorData lecs189 = new IndificatorData { IndificTeg = "виртуальность" };
            IndificatorData lecs190 = new IndificatorData { IndificTeg = "инновационный" };

            IndificatorData lecs191 = new IndificatorData { IndificTeg = "выпустит" };
            IndificatorData lecs192 = new IndificatorData { IndificTeg = "игра" };
            IndificatorData lecs193 = new IndificatorData { IndificTeg = "новый" };
            IndificatorData lecs194 = new IndificatorData { IndificTeg = "ии" };
            IndificatorData lecs195 = new IndificatorData { IndificTeg = "искусственныйинтеллект" };
            IndificatorData lecs196 = new IndificatorData { IndificTeg = "алгоритм" };
            IndificatorData lecs197 = new IndificatorData { IndificTeg = "обзор" };




            db.IndificatorData.Add(lecs1);
            db.IndificatorData.Add(lecs2);
            db.IndificatorData.Add(lecs3);
            db.IndificatorData.Add(lecs4);
            db.IndificatorData.Add(lecs5);
            db.IndificatorData.Add(lecs6);
            db.IndificatorData.Add(lecs7);
            db.IndificatorData.Add(lecs8);
            db.IndificatorData.Add(lecs9);
            db.IndificatorData.Add(lecs10);

            db.IndificatorData.Add(lecs11);
            db.IndificatorData.Add(lecs12);
            db.IndificatorData.Add(lecs13);
            db.IndificatorData.Add(lecs14);
            db.IndificatorData.Add(lecs15);
            db.IndificatorData.Add(lecs16);
            db.IndificatorData.Add(lecs17);
            db.IndificatorData.Add(lecs18);
            db.IndificatorData.Add(lecs19);
            db.IndificatorData.Add(lecs20);

            db.IndificatorData.Add(lecs21);
            db.IndificatorData.Add(lecs22);
            db.IndificatorData.Add(lecs23);
            db.IndificatorData.Add(lecs24);
            db.IndificatorData.Add(lecs25);
            db.IndificatorData.Add(lecs26);
            db.IndificatorData.Add(lecs27);
            db.IndificatorData.Add(lecs28);
            db.IndificatorData.Add(lecs29);
            db.IndificatorData.Add(lecs30);

            db.IndificatorData.Add(lecs31);
            db.IndificatorData.Add(lecs32);
            db.IndificatorData.Add(lecs33);
            db.IndificatorData.Add(lecs34);
            db.IndificatorData.Add(lecs35);
            db.IndificatorData.Add(lecs36);
            db.IndificatorData.Add(lecs37);
            db.IndificatorData.Add(lecs38);
            db.IndificatorData.Add(lecs39);
            db.IndificatorData.Add(lecs40);

            db.IndificatorData.Add(lecs41);
            db.IndificatorData.Add(lecs42);
            db.IndificatorData.Add(lecs43);
            db.IndificatorData.Add(lecs44);
            db.IndificatorData.Add(lecs45);
            db.IndificatorData.Add(lecs46);
            db.IndificatorData.Add(lecs47);
            db.IndificatorData.Add(lecs48);
            db.IndificatorData.Add(lecs49);
            db.IndificatorData.Add(lecs50);

            db.IndificatorData.Add(lecs51);
            db.IndificatorData.Add(lecs52);
            db.IndificatorData.Add(lecs53);
            db.IndificatorData.Add(lecs54);
            db.IndificatorData.Add(lecs55);
            db.IndificatorData.Add(lecs56);
            db.IndificatorData.Add(lecs57);
            db.IndificatorData.Add(lecs58);
            db.IndificatorData.Add(lecs59);
            db.IndificatorData.Add(lecs60);

            db.IndificatorData.Add(lecs61);
            db.IndificatorData.Add(lecs62);
            db.IndificatorData.Add(lecs63);
            db.IndificatorData.Add(lecs64);
            db.IndificatorData.Add(lecs65);
            db.IndificatorData.Add(lecs66);
            db.IndificatorData.Add(lecs67);
            db.IndificatorData.Add(lecs68);
            db.IndificatorData.Add(lecs69);
            db.IndificatorData.Add(lecs70);

            db.IndificatorData.Add(lecs71);
            db.IndificatorData.Add(lecs72);
            db.IndificatorData.Add(lecs73);
            db.IndificatorData.Add(lecs74);
            db.IndificatorData.Add(lecs75);
            db.IndificatorData.Add(lecs76);
            db.IndificatorData.Add(lecs77);
            db.IndificatorData.Add(lecs78);
            db.IndificatorData.Add(lecs79);
            db.IndificatorData.Add(lecs80);

            db.IndificatorData.Add(lecs81);
            db.IndificatorData.Add(lecs82);
            db.IndificatorData.Add(lecs83);
            db.IndificatorData.Add(lecs84);
            db.IndificatorData.Add(lecs85);
            db.IndificatorData.Add(lecs86);
            db.IndificatorData.Add(lecs87);
            db.IndificatorData.Add(lecs88);
            db.IndificatorData.Add(lecs89);
            db.IndificatorData.Add(lecs90);

            db.IndificatorData.Add(lecs91);
            db.IndificatorData.Add(lecs92);
            db.IndificatorData.Add(lecs93);
            db.IndificatorData.Add(lecs94);
            db.IndificatorData.Add(lecs95);
            db.IndificatorData.Add(lecs96);
            db.IndificatorData.Add(lecs97);
            db.IndificatorData.Add(lecs98);
            db.IndificatorData.Add(lecs99);
            db.IndificatorData.Add(lecs100);

            db.IndificatorData.Add(lecs101);
            db.IndificatorData.Add(lecs102);
            db.IndificatorData.Add(lecs103);
            db.IndificatorData.Add(lecs104);
            db.IndificatorData.Add(lecs105);
            db.IndificatorData.Add(lecs106);
            db.IndificatorData.Add(lecs107);
            db.IndificatorData.Add(lecs108);
            db.IndificatorData.Add(lecs109);
            db.IndificatorData.Add(lecs110);

            db.IndificatorData.Add(lecs111);
            db.IndificatorData.Add(lecs112);
            db.IndificatorData.Add(lecs113);
            db.IndificatorData.Add(lecs114);
            db.IndificatorData.Add(lecs115);
            db.IndificatorData.Add(lecs116);
            db.IndificatorData.Add(lecs117);
            db.IndificatorData.Add(lecs118);
            db.IndificatorData.Add(lecs119);
            db.IndificatorData.Add(lecs120);

            db.IndificatorData.Add(lecs121);
            db.IndificatorData.Add(lecs122);
            db.IndificatorData.Add(lecs123);
            db.IndificatorData.Add(lecs124);
            db.IndificatorData.Add(lecs125);
            db.IndificatorData.Add(lecs126);
            db.IndificatorData.Add(lecs127);
            db.IndificatorData.Add(lecs128);
            db.IndificatorData.Add(lecs129);
            db.IndificatorData.Add(lecs130);

            db.IndificatorData.Add(lecs131);
            db.IndificatorData.Add(lecs132);
            db.IndificatorData.Add(lecs133);
            db.IndificatorData.Add(lecs134);
            db.IndificatorData.Add(lecs135);
            db.IndificatorData.Add(lecs136);
            db.IndificatorData.Add(lecs137);
            db.IndificatorData.Add(lecs138);
            db.IndificatorData.Add(lecs139);
            db.IndificatorData.Add(lecs140);

            db.IndificatorData.Add(lecs141);
            db.IndificatorData.Add(lecs142);
            db.IndificatorData.Add(lecs143);
            db.IndificatorData.Add(lecs144);
            db.IndificatorData.Add(lecs145);
            db.IndificatorData.Add(lecs146);
            db.IndificatorData.Add(lecs147);
            db.IndificatorData.Add(lecs148);
            db.IndificatorData.Add(lecs149);
            db.IndificatorData.Add(lecs150);

            db.IndificatorData.Add(lecs151);
            db.IndificatorData.Add(lecs152);
            db.IndificatorData.Add(lecs153);
            db.IndificatorData.Add(lecs154);
            db.IndificatorData.Add(lecs155);
            db.IndificatorData.Add(lecs156);
            db.IndificatorData.Add(lecs157);
            db.IndificatorData.Add(lecs158);
            db.IndificatorData.Add(lecs159);
            db.IndificatorData.Add(lecs160);

            db.IndificatorData.Add(lecs161);
            db.IndificatorData.Add(lecs162);
            db.IndificatorData.Add(lecs163);
            db.IndificatorData.Add(lecs164);
            db.IndificatorData.Add(lecs165);
            db.IndificatorData.Add(lecs166);
            db.IndificatorData.Add(lecs167);
            db.IndificatorData.Add(lecs168);
            db.IndificatorData.Add(lecs169);
            db.IndificatorData.Add(lecs170);

            db.IndificatorData.Add(lecs171);
            db.IndificatorData.Add(lecs172);
            db.IndificatorData.Add(lecs173);
            db.IndificatorData.Add(lecs174);
            db.IndificatorData.Add(lecs175);
            db.IndificatorData.Add(lecs176);
            db.IndificatorData.Add(lecs177);
            db.IndificatorData.Add(lecs178);
            db.IndificatorData.Add(lecs179);
            db.IndificatorData.Add(lecs180);

            db.IndificatorData.Add(lecs181);
            db.IndificatorData.Add(lecs182);
            db.IndificatorData.Add(lecs183);
            db.IndificatorData.Add(lecs184);
            db.IndificatorData.Add(lecs185);
            db.IndificatorData.Add(lecs186);
            db.IndificatorData.Add(lecs187);
            db.IndificatorData.Add(lecs188);
            db.IndificatorData.Add(lecs189);
            db.IndificatorData.Add(lecs190);

            db.IndificatorData.Add(lecs191);
            db.IndificatorData.Add(lecs192);
            db.IndificatorData.Add(lecs193);
            db.IndificatorData.Add(lecs194);
            db.IndificatorData.Add(lecs195);
            db.IndificatorData.Add(lecs196);
            db.IndificatorData.Add(lecs197);
         
        }
    }
}

