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

            Console.WriteLine("Далее Вам будут заданы вопросы для подбора соответствующего Вам антивирусного пакета. Ответьте на них, используя 10-балльную шкалу (вводите цифры от 0 до 10).\r\n");
            
            Console.WriteLine("Насколько Вам важна надежность антивирусного пакета?");
            do
            {
                result = int.TryParse(Console.ReadLine(), out security);
                if (result || security < 0 || security > 10)
                {
                    Console.WriteLine("Введите Вашу оценку по 10-балльной шкале (от 0 до 10)");
                }
            } while (!result || security < 0 || security > 10);
            Console.WriteLine(security);

            Console.WriteLine("Насколько Вам важно удобство использования антивирусного пакета?");
            do
            {
                result = int.TryParse(Console.ReadLine(), out ease_of_use);
                if (result || ease_of_use < 0 || ease_of_use > 10)
                {
                    Console.WriteLine("Введите Вашу оценку по 10-балльной шкале (от 0 до 10)");
                }
            } while (!result || ease_of_use < 0 || ease_of_use > 10);
            Console.WriteLine(ease_of_use);

            Console.WriteLine("Насколько Вам важно наличие комплексной защиты?");
            do
            {
                result = int.TryParse(Console.ReadLine(), out comprehensive_protection_availability);
                if (result || comprehensive_protection_availability < 0 || comprehensive_protection_availability > 10)
                {
                    Console.WriteLine("Введите Вашу оценку по 10-балльной шкале (от 0 до 10)");
                }
            } while (!result || comprehensive_protection_availability < 0 || comprehensive_protection_availability > 10);
            Console.WriteLine(comprehensive_protection_availability);

            Console.WriteLine("Насколько Вам важно качество защиты?");
            do
            {
                result = int.TryParse(Console.ReadLine(), out protection_quality);
                if (result || protection_quality < 0 || protection_quality > 10)
                {
                    Console.WriteLine("Введите Вашу оценку по 10-балльной шкале (от 0 до 10)");
                }
            } while (!result || protection_quality < 0 || protection_quality > 10);
            Console.WriteLine(protection_quality);

            Console.WriteLine("Насколько Вам важна высокая эффективность обнаружения угроз?");
            do
            {
                result = int.TryParse(Console.ReadLine(), out efficiency_of_threat_detection);
                if (result || efficiency_of_threat_detection < 0 || efficiency_of_threat_detection > 10)
                {
                    Console.WriteLine("Введите Вашу оценку по 10-балльной шкале (от 0 до 10)");
                }
            } while (!result || efficiency_of_threat_detection < 0 || efficiency_of_threat_detection > 10);
            Console.WriteLine(efficiency_of_threat_detection);

            Console.WriteLine("Насколько Вам важен обьем занимаемой антивирусным пакетом памяти?");
            do
            {
                result = int.TryParse(Console.ReadLine(), out memory_footprint);
                if (result || memory_footprint < 0 || memory_footprint > 10)
                {
                    Console.WriteLine("Введите Вашу оценку по 10-балльной шкале (от 0 до 10)");
                }
            } while (!result || memory_footprint < 0 || memory_footprint > 10);
            Console.WriteLine(memory_footprint);

            Console.WriteLine("Насколько Вам важна высокая частота получения обновлений?");
            do
            {
                result = int.TryParse(Console.ReadLine(), out update_frequency);
                if (result || update_frequency < 0 || update_frequency > 10)
                {
                    Console.WriteLine("Введите Вашу оценку по 10-балльной шкале (от 0 до 10)");
                }
            } while (!result || update_frequency < 0 || update_frequency > 10);
            Console.WriteLine(update_frequency);

            Console.WriteLine("Насколько Вам важна возможность вылечить зараженый компьютер?");
            do
            {
                result = int.TryParse(Console.ReadLine(), out infected_computer_curing);
                if (result || infected_computer_curing < 0 || infected_computer_curing > 10)
                {
                    Console.WriteLine("Введите Вашу оценку по 10-балльной шкале (от 0 до 10)");
                }
            } while (!result || infected_computer_curing < 0 || infected_computer_curing > 10);
            Console.WriteLine(infected_computer_curing);

            Console.WriteLine("Насколько Вам важно низкое влияние на производительность?");
            do
            {
                result = int.TryParse(Console.ReadLine(), out performance_impact);
                if (result || performance_impact < 0 || performance_impact > 10)
                {
                    Console.WriteLine("Введите Вашу оценку по 10-балльной шкале (от 0 до 10)");
                }
            } while (!result || performance_impact < 0 || performance_impact > 10);
            Console.WriteLine(performance_impact);

            Console.WriteLine("Насколько Вам важна высокая периодичность обновления вирусных баз?");
            do
            {
                result = int.TryParse(Console.ReadLine(), out virus_database_updates_frequency);
                if (result || virus_database_updates_frequency < 0 || virus_database_updates_frequency > 10)
                {
                    Console.WriteLine("Введите Вашу оценку по 10-балльной шкале (от 0 до 10)");
                }
            } while (!result || virus_database_updates_frequency < 0 || virus_database_updates_frequency > 10);
            Console.WriteLine(virus_database_updates_frequency);





        }
    }
}