using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashDisk_OOP
{
    class MemoryEEprom
    {
        int rychlostEEprom;
        int ulozisteeprom=15;
        int data;

        public MemoryEEprom(int rychlostEEprom)
        {
            this.rychlostEEprom = rychlostEEprom;
            
        }

        public int UlozisteEprom//zaklad 15
        {
            get
            {
                return ulozisteeprom;
            }
        }
        public bool PosliDoFlash(int daticka)
        {
            if (daticka > ulozisteeprom)
            {
                MessageBox.Show("Data nebyla poslána, data jsou větší než: " + UlozisteEprom + "gb");
                this.data = 0;
                return false;// chtěl jsem dát info flash paměti, že se data neuloží do eepromky a tudíž nemůže tahat data z eeprom

            }
            else
            {
                MessageBox.Show("Data úspěšně poslána!");
                this.data = daticka;
                return true;    
            }

        }

        public override string ToString()
        {
            if (data == 0)
            {
                return "EEpromka s uložistěm: " + ulozisteeprom + " a rychlostí: " + rychlostEEprom + " neposalala data úložišti FLASH, protože data byli větší než: "+UlozisteEprom;
            }
            else
            {
                return "EEpromka s uložistěm: " + ulozisteeprom + " a rychlostí: " + rychlostEEprom + " Poslala Data úložišti o hodnotě: "+ data;
            }

        }
    }
}
