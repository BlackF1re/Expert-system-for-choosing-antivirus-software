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
            List<string> namesOfSoft = new()
            {
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
                "Gridinsoft (no cloud)"
            };
            //foreach (var name in namesOfSoft)
            //    Console.WriteLine(name);

            int security;
            int ease_of_use;
            int comprehensive_protection_availability;
            int protection_quality;
            int efficiency_of_threat_detection;
            int memory_footprint;
            int update_frequency;
            int infected_computer_curing;
            int performance_impact;
            int virus_database_updates_frequency;

            bool result;

            Console.WriteLine("Далее Вам будут заданы вопросы для подбора соответствующего Вам антивирусного пакета. Ответьте на них, используя цифры 1 или 2 (ДА или НЕТ соответственно)\r\n");
            
            Console.WriteLine("Вам важна надежность антивирусного пакета?");
            do
            {
                result = int.TryParse(Console.ReadLine(), out security);
            } while (!result || security < 1 || security > 2);
            Console.WriteLine(security);//first decision

            if (security == 1)//vetka 1
            {
                Console.WriteLine("Важно ли удобство использования антивирусного пакета");
                do
                {
                    result = int.TryParse(Console.ReadLine(), out ease_of_use);
                } while (!result || ease_of_use < 1 || ease_of_use > 2);
                Console.WriteLine(ease_of_use);
                
                if (ease_of_use == 1)
                Console.WriteLine("Вам  важна ");
            }


            else if (security == 2)//vetka 2
            {
                Console.WriteLine("Вам важно наличие комплексной защиты?");
                do
                {
                    result = int.TryParse(Console.ReadLine(), out comprehensive_protection_availability);
                } while (!result || comprehensive_protection_availability < 1 || comprehensive_protection_availability > 2);
                Console.WriteLine(comprehensive_protection_availability);
                if(comprehensive_protection_availability == 1)
                {
                    Console.WriteLine(comprehensive_protection_availability);
                }
            }













            //Console.WriteLine("Вам важно удобство использования антивирусного пакета?");
            //do
            //{
            //    result = int.TryParse(Console.ReadLine(), out ease_of_use);
            //} while (!result || ease_of_use < 1 || ease_of_use > 2);
            //Console.WriteLine(ease_of_use);

            //Console.WriteLine("Вам важно наличие комплексной защиты?");
            //do
            //{
            //    result = int.TryParse(Console.ReadLine(), out comprehensive_protection_availability);
            //} while (!result || comprehensive_protection_availability < 1 || comprehensive_protection_availability > 2);
            //Console.WriteLine(comprehensive_protection_availability);

            //Console.WriteLine("Насколько Вам важно качество защиты?");
            //do
            //{
            //    result = int.TryParse(Console.ReadLine(), out protection_quality);
            //} while (!result || protection_quality < 1 || protection_quality > 2);
            //Console.WriteLine(protection_quality);

            //Console.WriteLine("Насколько Вам важна высокая эффективность обнаружения угроз?");
            //do
            //{
            //    result = int.TryParse(Console.ReadLine(), out efficiency_of_threat_detection);
            //} while (!result || efficiency_of_threat_detection < 1 || efficiency_of_threat_detection > 2);
            //Console.WriteLine(efficiency_of_threat_detection);

            //Console.WriteLine("Насколько Вам важен обьем занимаемой антивирусным пакетом памяти?");
            //do
            //{
            //    result = int.TryParse(Console.ReadLine(), out memory_footprint);
            //} while (!result || memory_footprint < 1 || memory_footprint > 2);
            //Console.WriteLine(memory_footprint);

            //Console.WriteLine("Насколько Вам важна высокая частота получения обновлений?");
            //do
            //{
            //    result = int.TryParse(Console.ReadLine(), out update_frequency);
            //} while (!result || update_frequency < 1 || update_frequency > 2);
            //Console.WriteLine(update_frequency);

            //Console.WriteLine("Насколько Вам важна возможность вылечить зараженый компьютер?");
            //do
            //{
            //    result = int.TryParse(Console.ReadLine(), out infected_computer_curing);
            //} while (!result || infected_computer_curing < 1 || infected_computer_curing > 2);
            //Console.WriteLine(infected_computer_curing);

            //Console.WriteLine("Насколько Вам важно низкое влияние на производительность?");
            //do
            //{
            //    result = int.TryParse(Console.ReadLine(), out performance_impact);
            //} while (!result || performance_impact < 1 || performance_impact > 2);
            //Console.WriteLine(performance_impact);

            //Console.WriteLine("Насколько Вам важна высокая периодичность обновления вирусных баз?");
            //do
            //{
            //    result = int.TryParse(Console.ReadLine(), out virus_database_updates_frequency);
            //} while (!result || virus_database_updates_frequency < 1 || virus_database_updates_frequency > 2);
            //Console.WriteLine(virus_database_updates_frequency);





        }
    }
}