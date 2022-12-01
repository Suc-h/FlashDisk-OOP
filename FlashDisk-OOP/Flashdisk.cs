using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashDisk_OOP
{
    class Flashdisk
    {
        
        
        string barva="modra";//zaklad modra
        int rychlost=5;//zaklad 5
        int dataz;// data z eeprom
        
        
        string vyrobce = "ASUS"; // zaklad asus

        int memoryflash = 5;//zaklad 5gb

        public Flashdisk(string barva, int rychlost)
        {
            this.barva = barva;
            this.rychlost = rychlost;
        }

        public Flashdisk()
        {

        }

        public int Memoryflash // write , read
        {
            get
            {
                return memoryflash;
            }
            set
            {
                this.memoryflash = value;

            }
        }
        public string Vyrobce // read-only
        {
            get
            {
                return vyrobce;
            }
        }

        

        public void UlozVFlash(int dataze)
        {
            if(dataze>memoryflash) //test jestli se data vejdou
            {
                this.dataz = 0;
            }
            else
            {
                this.dataz = dataze;
            }


        }


        

        public override string ToString()
        {
            if (dataz == 0)
            {
                return "Flash s pamětí flash o hodnotě: " + Memoryflash + " a barvičkou: " + barva + " a vyrobcem: " + Vyrobce + " neuložila žádné data, důvod: Data byla větší než velikost úložiště flash paměti!";
            }
            else
            {
                return "Flash s pamětí flash o hodnotě: " + Memoryflash + " a barvičkou: " + barva + " a vyrobcem: "+Vyrobce+" uložila data o hodnotě: " + dataz;
            }

        }
    }
}
