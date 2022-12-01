using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashDisk_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Flashdisk flash = new Flashdisk(textBox1.Text, (int)numericUpDown1.Value);//1. flash
            Flashdisk flashw = new Flashdisk();//2. flash se zakladem



            flash.UlozVFlash((int)numericUpDown3.Value);//načte data z eeprom
            MessageBox.Show(flash.ToString()); // vypíše info

            flash.Memoryflash = (int)numericUpDown4.Value;//změní hodnotu úložiště
            /*if(eprom.poslidoflash()==true)
             * {
             * flash.UlozVFlash((int)numericUpDown3.Value);//načte data z eeprom
             * }
             * else
             * {
             * 
             * }
            */
            flash.UlozVFlash((int)numericUpDown3.Value);//načte data z eeprom
            MessageBox.Show(flash.ToString());//vypíše nové info


            flashw.UlozVFlash((int)numericUpDown3.Value);//načte data z eeprom  
            MessageBox.Show(flashw.ToString()); // vypíše info o flash se zakladem




        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemoryEEprom eprom = new MemoryEEprom((int)numericUpDown2.Value);//eeprom

            eprom.PosliDoFlash((int)numericUpDown3.Value);//načte data od uživatele a vyzkouší zda se vejdou do eeprom
            MessageBox.Show(eprom.ToString());//vypíše info
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Začni s zadáváním informací do políček. Poté klikni na tlačítko start. Jakmile proces doběhne do konce, zkontroluj zda jsou vyplněné všechny políčka u tlačítka continue. Pokud ano, klikni na tlačítko continue.", "HELP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
    }
}
