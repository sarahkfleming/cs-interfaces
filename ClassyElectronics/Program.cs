using System;
using System.Collections.Generic;

namespace ClassyElectronics
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio1 = new Radio();
            Radio radio2 = new Radio();
            Allinator radio3 = new Allinator();
            Allinator radio4 = new Allinator();
            
            List<IRadio> iRadioList = new List<IRadio>()
            {
                radio1, radio2, radio3, radio4
            };
            
            TestRadios(iRadioList);
            
            Speakanator3001 turnTable1 = new Speakanator3001();
            Allinator turnTable2 = new Allinator();
            
            List<ITurnTable> iTurnTableList = new List<ITurnTable>()
            {
              turnTable1, turnTable2  
            };
            
            TestTurnTables(iTurnTableList);
        }
        
        static void TestRadios(List<IRadio> radios)
        {
            foreach(IRadio radio in radios)
            {
                radio.TurnRadioOn();
                Console.WriteLine($"The radio is on.");
                radio.TurnRadioOff();
                Console.WriteLine($"The radio is off.");
            }
        }
        
        static void TestTurnTables(List<ITurnTable> turnTables)
        {
            foreach(ITurnTable turnTable in turnTables)
            {
                turnTable.Play();
                Console.WriteLine($"The Turn Table is playing.");
                turnTable.Stop();
                Console.WriteLine($"The Turn Table is not playing.");
            }
        }
    }
}
