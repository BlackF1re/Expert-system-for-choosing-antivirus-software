using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Expert_system_for_choosing_antivirus_software
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> knowledgeBase = new()
            {
                "[zero_index]",
                "Acronis(Static ML)",
                "Ad-Aware",
                "AhnLab-V3",
                "Alibaba",
                "ALYac",
                "Antiy-AVL",
                "Arcabit",
                "Avast",
                "Avira (no cloud)",
                "Baidu",
                "BitDefender",
                "BitDefenderTheta",
                "Bkav Pro",
                "ClamAV",
                "CMC",
                "Comodo",
                "CrowdStrike Falcon",
                "Cybereason",
                "Cylance",
                "Cynet",
                "Cyren",
                "DrWeb",
                "Elastic",
                "Emsisoft",
                "eScan",
                "ESET-NOD32",
                "F-Secure",
                "Fortinet",
                "GData",
                "Gridinsoft (no cloud)",
                "Ikarus",
                "Jiangmin",
                "K7AntiVirus",
                "K7GW",
                "Kaspersky",
                "Kingsoft",
                "Lionic",
                "Malwarebytes",
                "MAX",
                "MaxSecure",
                "McAfee",
                "McAfee-GW-Edition",
                "Microsoft",
                "NANO-Antivirus",
                "Palo Alto Networks",
                "QuickHeal",
                "Rising",
                "Sangfor Engine Zero",
                "SecureAge",
                "SentinelOne (Static ML)"
            };

            int firstChoise;
            int secondChoice;
            int thirdChoice;

            int finalChoice;

            bool result;

            Console.WriteLine("Далее Вам будут заданы вопросы для подбора соответствующего Вам антивирусного пакета. Ответьте на них, используя соответствующие цифры\r\n");

            a: 
            Console.WriteLine("Какой тип антивирусного ПО вам требуется? 1-Антивирусный сканер, 2-Антивирусный сторож, 3-Полифаг, 4-Ревизор, 5-Блокировщик");
            do
            {
                result = int.TryParse(Console.ReadLine(), out firstChoise);
            } while (!result || firstChoise < 1 || firstChoise > 5);
            //Console.WriteLine(firstChoise);

            Console.WriteLine("Вам необходим платный продукт? 1-Платный, 2-Бесплатный");
            do
            {
                result = int.TryParse(Console.ReadLine(), out secondChoice);
            } while (!result || secondChoice < 1 || secondChoice > 2);
            //Console.WriteLine(secondChoice);

            Console.WriteLine("Выберите операционную систему, на которую собираетесь устанавливать продукт. 1-Windows, 2-Linux, 3-Mac, 4-Android, 5-IOS");
            do
            {
                result = int.TryParse(Console.ReadLine(), out thirdChoice);
            } while (!result || thirdChoice < 1 || thirdChoice > 5);
            //Console.WriteLine(thirdChoice);

            Console.WriteLine("Рекомендованное решение:");

            //Условия для 1-1-х
            if (firstChoise == 1 && secondChoice == 1 && thirdChoice == 1)
                Console.WriteLine(knowledgeBase[1]);
            if (firstChoise == 1 && secondChoice == 1 && thirdChoice == 2)
                Console.WriteLine(knowledgeBase[2]);
            if (firstChoise == 1 && secondChoice == 1 && thirdChoice == 3)
                Console.WriteLine(knowledgeBase[3]);
            if (firstChoise == 1 && secondChoice == 1 && thirdChoice == 4)
                Console.WriteLine(knowledgeBase[4]);
            if (firstChoise == 1 && secondChoice == 1 && thirdChoice == 5)
                Console.WriteLine(knowledgeBase[5]);

            //Условия для 1-2-х
            if (firstChoise == 1 && secondChoice == 2 && thirdChoice == 1)
                Console.WriteLine(knowledgeBase[6]);
            if (firstChoise == 1 && secondChoice == 2 && thirdChoice == 2)
                Console.WriteLine(knowledgeBase[7]);
            if (firstChoise == 1 && secondChoice == 2 && thirdChoice == 3)
                Console.WriteLine(knowledgeBase[8]);
            if (firstChoise == 1 && secondChoice == 2 && thirdChoice == 4)
                Console.WriteLine(knowledgeBase[9]);
            if (firstChoise == 1 && secondChoice == 2 && thirdChoice == 5)
                Console.WriteLine(knowledgeBase[10]);

            //Условия для 2-1-х
            if (firstChoise == 2 && secondChoice == 1 && thirdChoice == 1)
                Console.WriteLine(knowledgeBase[11]);
            if (firstChoise == 2 && secondChoice == 1 && thirdChoice == 2)
                Console.WriteLine(knowledgeBase[12]);
            if (firstChoise == 2 && secondChoice == 1 && thirdChoice == 3)
                Console.WriteLine(knowledgeBase[13]);
            if (firstChoise == 2 && secondChoice == 1 && thirdChoice == 4)
                Console.WriteLine(knowledgeBase[14]);
            if (firstChoise == 2 && secondChoice == 1 && thirdChoice == 5)
                Console.WriteLine(knowledgeBase[15]);
            
            //Условия для 2-2-х
            if (firstChoise == 2 && secondChoice == 2 && thirdChoice == 1)
                Console.WriteLine(knowledgeBase[16]);
            if (firstChoise == 2 && secondChoice == 2 && thirdChoice == 2)
                Console.WriteLine(knowledgeBase[17]);
            if (firstChoise == 2 && secondChoice == 2 && thirdChoice == 3)
                Console.WriteLine(knowledgeBase[18]);
            if (firstChoise == 2 && secondChoice == 2 && thirdChoice == 4)
                Console.WriteLine(knowledgeBase[19]);
            if (firstChoise == 2 && secondChoice == 2 && thirdChoice == 5)
                Console.WriteLine(knowledgeBase[20]);

            //Условия для 3-1-х
            if (firstChoise == 3 && secondChoice == 1 && thirdChoice == 1)
                Console.WriteLine(knowledgeBase[21]);
            if (firstChoise == 3 && secondChoice == 1 && thirdChoice == 2)
                Console.WriteLine(knowledgeBase[22]);
            if (firstChoise == 3 && secondChoice == 1 && thirdChoice == 3)
                Console.WriteLine(knowledgeBase[23]);
            if (firstChoise == 3 && secondChoice == 1 && thirdChoice == 4)
                Console.WriteLine(knowledgeBase[24]);
            if (firstChoise == 3 && secondChoice == 1 && thirdChoice == 5)
                Console.WriteLine(knowledgeBase[25]);

            //Условия для 3-2-х
            if (firstChoise == 3 && secondChoice == 2 && thirdChoice == 1)
                Console.WriteLine(knowledgeBase[26]);
            if (firstChoise == 3 && secondChoice == 2 && thirdChoice == 2)
                Console.WriteLine(knowledgeBase[27]);
            if (firstChoise == 3 && secondChoice == 2 && thirdChoice == 3)
                Console.WriteLine(knowledgeBase[28]);
            if (firstChoise == 3 && secondChoice == 2 && thirdChoice == 4)
                Console.WriteLine(knowledgeBase[29]);
            if (firstChoise == 3 && secondChoice == 2 && thirdChoice == 5)
                Console.WriteLine(knowledgeBase[30]);

            //Условия для 4-1-х
            if (firstChoise == 4 && secondChoice == 1 && thirdChoice == 1)
                Console.WriteLine(knowledgeBase[31]);
            if (firstChoise == 4 && secondChoice == 1 && thirdChoice == 2)
                Console.WriteLine(knowledgeBase[32]);
            if (firstChoise == 4 && secondChoice == 1 && thirdChoice == 3)
                Console.WriteLine(knowledgeBase[33]);
            if (firstChoise == 4 && secondChoice == 1 && thirdChoice == 4)
                Console.WriteLine(knowledgeBase[34]);
            if (firstChoise == 4 && secondChoice == 1 && thirdChoice == 5)
                Console.WriteLine(knowledgeBase[35]);

            //Условия для 4-2-х
            if (firstChoise == 4 && secondChoice == 2 && thirdChoice == 1)
                Console.WriteLine(knowledgeBase[36]);
            if (firstChoise == 4 && secondChoice == 2 && thirdChoice == 2)
                Console.WriteLine(knowledgeBase[37]);
            if (firstChoise == 4 && secondChoice == 2 && thirdChoice == 3)
                Console.WriteLine(knowledgeBase[38]);
            if (firstChoise == 4 && secondChoice == 2 && thirdChoice == 4)
                Console.WriteLine(knowledgeBase[39]);
            if (firstChoise == 4 && secondChoice == 2 && thirdChoice == 5)
                Console.WriteLine(knowledgeBase[40]);

            //Условия для 5-1-х
            if (firstChoise == 5 && secondChoice == 1 && thirdChoice == 1)
                Console.WriteLine(knowledgeBase[41]);
            if (firstChoise == 5 && secondChoice == 1 && thirdChoice == 2)
                Console.WriteLine(knowledgeBase[42]);
            if (firstChoise == 5 && secondChoice == 1 && thirdChoice == 3)
                Console.WriteLine(knowledgeBase[43]);
            if (firstChoise == 5 && secondChoice == 1 && thirdChoice == 4)
                Console.WriteLine(knowledgeBase[44]);
            if (firstChoise == 5 && secondChoice == 1 && thirdChoice == 5)
                Console.WriteLine(knowledgeBase[45]);

            //Условия для 5-2-х
            if (firstChoise == 5 && secondChoice == 2 && thirdChoice == 1)
                Console.WriteLine(knowledgeBase[46]);
            if (firstChoise == 5 && secondChoice == 2 && thirdChoice == 2)
                Console.WriteLine(knowledgeBase[47]);
            if (firstChoise == 5 && secondChoice == 2 && thirdChoice == 3)
                Console.WriteLine(knowledgeBase[48]);
            if (firstChoise == 5 && secondChoice == 2 && thirdChoice == 4)
                Console.WriteLine(knowledgeBase[49]);
            if (firstChoise == 5 && secondChoice == 2 && thirdChoice == 5)
                Console.WriteLine(knowledgeBase[50]);
            Console.WriteLine("Вас устроил полученный результат? 1-Да (выход из программы), 0-Нет (перепройти тестирование)");
            do
            {
                result = int.TryParse(Console.ReadLine(), out finalChoice);
            } while (!result || finalChoice > 1 || finalChoice < 0);


            if (finalChoice == 0)
                goto a;
            if (finalChoice == 1)
                System.Environment.Exit(1488);

        }
    }
}