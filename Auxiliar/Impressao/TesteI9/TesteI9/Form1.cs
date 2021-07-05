using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteI9
{
    public partial class Form1 : Form
    {

        EscPos esc = new EscPos();
       
        //windows's default printer
        public static string DefaultPrinterName()
        {
            return new System.Drawing.Printing.PrintDocument().PrinterSettings.PrinterName;
        }

        //linefeed and paper cutter
        public void feedAndCutter(string printerName, int numLines) {
            System.Threading.Thread.Sleep(500);
            this.esc.lineFeed(printerName, numLines);
            this.esc.CutPaper(printerName);
        }

        public Form1()
        {
           
            InitializeComponent();
            PopulateInstalledPrintersCombo(); 
            //comboInstalledPrinters.Items.Add(DefaultPrinterName());
            
            
        }


        private void PopulateInstalledPrintersCombo()
        {
               


            //list of the printers
            String pkInstalledPrinters;
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                comboInstalledPrinters4.Items.Add(pkInstalledPrinters);
                comboInstalledPrinters3.Items.Add(pkInstalledPrinters);
                comboInstalledPrinters2.Items.Add(pkInstalledPrinters);
                comboInstalledPrinters1.Items.Add(pkInstalledPrinters);
                comboInstalledPrinters5.Items.Add(pkInstalledPrinters);
                comboInstalledPrinters6.Items.Add(pkInstalledPrinters);
            }
        }

       

        
        private void button1_Click(object sender, EventArgs e)
        {
            
           string printerName=comboInstalledPrinters2.SelectedItem.ToString();
           string strdata = textBoxUrl.Text.ToString();
     
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
           //for test

           //996 chars
           string strdata2 = "Ser ou não ser, eis a questão: será mais nobre em nosso espírito sofrer pedras e setas com que a Fortuna, enfurecida, nos alveja, ou insurgir-nos contra um mar de provações e em luta pôr-lhes fim? Morrer... dormir: não mais. Dizer que rematamos com um sono a angústia e as mil pelejas naturaisherança do homem: Morrer para dormir... é uma consumação que bem merece e desejamos com fervor. Dormir... Talvez sonhar: eis onde surge o obstáculo: Pois quando livres do tumulto da existência, no repouso da morte o sonho que tenhamos devem fazer-nos hesitar: eis a suspeita que impõe tão longa vida aos nossos infortúnios. Quem sofreria os relhos e a irrisão do mundo, o agravo do opressor, a afronta do orgulhoso, toda a lancinação do mal-prezado amor, a insolência oficial, as dilações da lei, os doestos que dos nulos têm de suportar o mérito paciente, quem o sofreria, quando alcançasse a mais perfeita quitação com a ponta de um punhal? Quem levaria fardos, gemendo e suando sob a vida fatigante.";   
           
           //380 chars
           string strdata4 = "Ser ou não ser, eis a questão: será mais nobre em nosso espírito sofrer pedras e setas com que a Fortuna, enfurecida, nos alveja, ou insurgir-nos contra um mar de provações e em luta pôr-lhes fim? Morrer... dormir: não mais. Dizer que rematamos com um sono a angústia e as mil pelejas naturaisherança do homem: Morrer para dormir... é uma consumação que bem merece e desejamos com";
           
           //381 chars
           string strdata5 = "Ser ou não ser, eis a questão: será mais nobre em nosso espírito sofrer pedras e setas com que a Fortuna, enfurecida, nos alveja, ou insurgir-nos contra um mar de provações e em luta pôr-lhes fim? Morrer... dormir: não mais. Dizer que rematamos com um sono a angústia e as mil pelejas naturaisherança do homem: Morrer para dormir... é uma consumação que bem merece e desejamos co"; 
            
           //382 chars 
           string strdata6 = "Loremipsumdolorsitamet,consecteturadipiscingelit.Quisqueac molestieturpis.Suspendisseefficiturcondimentumfaucibus.Nammattisnullarisus,ataliquamnibhtristiquea.Maecenasinaliquet risus.Sedinterdum,duisedconsecteturscelerisque,orciorcibibendumfelis,nonfringillaturpisfelisegetjusto.Nuncvariusnuncegetorcivariusmattis.Integersagittisvitaeodioidvulputate.Pellente12345678911234567891012";  
          
            //383 chars
           string strdata7 = "Loremipsumdolorsitamet,consecteturadipiscingelit.Quisqueac molestieturpis.Suspendisseefficiturcondimentumfaucibus.Nammattisnulla risus,ataliquamnibhtristiquea.Maecenasinaliquet risus.Sed interdum,duisedconsecteturscelerisque,orciorcibibendumfelis,nonfringillaturpisfelisegetjusto.Nuncv ariusnuncegetorcivariusmattis.Integersagittisvitaeodioidvulputate.Pellente12345678911234567891012a";

           string strdata8 = "https://homnfce.sefaz.am.gov.br/nfceweb/consultarNFCe.jsp?chNFe=13150100531968000144650060000002819684898980&nVersao=100&tpAmb=2&dhEmi=323031352d30312d32365431373a33303a32382d30323a3030&vNF=2.20&vICMS=0.00&digVal=&cIdToken=000001&cHashQRCode=7bbfb77b30d2b767fa026fe1f2004a0800601e01";

           //500 chars
           string strdata9 = "Ser ou não ser, eis a questão: será mais nobre em nosso espírito sofrer pedras e setas com que a Fortuna, enfurecida, nos alveja, ou insurgir-nos contra um mar de provações e em luta pôr-lhes fim? Morrer... dormir: não mais. Dizer que rematamos com um sono a angústia e as mil pelejas naturaisherança do homem: Morrer para dormir... é uma consumação que bem merece e desejamos com fervor. Dormir... Talvez sonhar: eis onde surge o obstáculo: Pois quando livres do tumulto da existência, no repouso da";
        
           //700 chars
           string strdata11 = "Ser ou não ser, eis a questão: será mais nobre em nosso espírito sofrer pedras e setas com que a Fortuna, enfurecida, nos alveja, ou insurgir-nos contra um mar de provações e em luta pôr-lhes fim? Morrer... dormir: não mais. Dizer que rematamos com um sono a angústia e as mil pelejas naturaisherança do homem: Morrer para dormir... é uma consumação que bem merece e desejamos com fervor. Dormir... Talvez sonhar: eis onde surge o obstáculo: Pois quando livres do tumulto da existência, no repouso da morte o sonho que tenhamos devem fazer-nos hesitar: eis a suspeita que impõe tão longa vida aos nossos infortúnios. Quem sofreria os relhos e a irrisão do mundo, o agravo do opressor, a afronta do or";

           //450 chars
           string strdata10 = "Ser ou não ser, eis a questão: será mais nobre em nosso espírito sofrer pedras e setas com que a Fortuna, enfurecida, nos alveja, ou insurgir-nos contra um mar de provações e em luta pôr-lhes fim? Morrer... dormir: não mais. Dizer que rematamos com um sono a angústia e as mil pelejas naturaisherança do homem: Morrer para dormir... é uma consumação que bem merece e desejamos com fervor. Dormir... Talvez sonhar: eis onde surge o obstáculo: Pois  ";
           // -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
           
           this.esc.printText(printerName, "QRCODE:\n");
           
           this.esc.printQrcode(strdata,printerName);
           this.esc.lineFeed(printerName, 1);
           // feedAndCutter(printerName,7);
          
               
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Allow the user to select a file.
            OpenFileDialog ofd = new OpenFileDialog();
            if (DialogResult.OK == ofd.ShowDialog(this))
            {
                // Allow the user to select a printer.
                PrintDialog pd = new PrintDialog();
                pd.PrinterSettings = new PrinterSettings();
                if (DialogResult.OK == pd.ShowDialog(this))
                {
                    // Print the file to the printer.
                    RawPrinterHelper.SendFileToPrinter(pd.PrinterSettings.PrinterName, ofd.FileName);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            
            
           
            string s = textBoxCupom.Text;

            // Allow the user to select a printer.
            PrintDialog pd = new PrintDialog();
            pd.PrinterSettings = new PrinterSettings();
            if (DialogResult.OK == pd.ShowDialog(this))
            {
                
                
                RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, s);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            int numLines=5;
            string printerName = comboInstalledPrinters1.SelectedItem.ToString();
            for (int i = 0; i <= 9; i++) {
                
                this.esc.lineFeed(printerName,numLines);
                               
                this.esc.CutPaper(printerName);  
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {   
            string printerName = comboInstalledPrinters1.SelectedItem.ToString();
           
            this.esc.buzzer(printerName);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            string printerName = comboInstalledPrinters1.SelectedItem.ToString();

            this.esc.testPrint(printerName);
        }

        private void button6_Click(object sender, EventArgs e)
        {   
             string printerName = comboInstalledPrinters1.SelectedItem.ToString();
             this.esc.drawerKick(printerName);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
              
            string data= tbSpecialText.Text.ToString();
            string printerName = comboInstalledPrinters3.SelectedItem.ToString();
            this.esc.printText(printerName, data);
            
            feedAndCutter(printerName, 5);

            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string data = tbSpecialChars.Text.ToString();
            string printerName = comboInstalledPrinters4.SelectedItem.ToString();
            this.esc.printText(printerName, data);
            feedAndCutter(printerName, 5); 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //string data = "font A (12 × 24) selected.\n";
            string data = "0123456789012345678901234567890123\n";
            string printerName = comboInstalledPrinters5.SelectedItem.ToString();
            this.esc.charFontAText(printerName);
            this.esc.printText(printerName, data);

            //data = "character font B (9 × 17) selected.\n";
            data = "0123456789012345678901234567890123\n";
            //this.esc.normalModeText(printerName);
            this.esc.charFontBText(printerName);
            this.esc.printText(printerName, data);

            data = "Emphasized mode is turned on.\n";
            //this.esc.normalModeText(printerName);
            this.esc.emphasizedModeText(printerName);
            this.esc.printText(printerName, data);

            data = "Double-height selected.\n";
            //this.esc.normalModeText(printerName);
            this.esc.doubleHeightText(printerName);
            this.esc.printText(printerName, data);

            data = "Double-width selected\n";
            //this.esc.normalModeText(printerName);
            this.esc.DoubleWidthText(printerName);
            this.esc.printText(printerName, data);

            data = "Underline mode is turned on.\n";
            //this.esc.normalModeText(printerName);
            this.esc.UnderlineModeText(printerName);
            this.esc.printText(printerName, data);

            //return to normal mode.
            this.esc.normalModeText(printerName);

            feedAndCutter(printerName, 7);
        }

        private void button11_Click(object sender, EventArgs e)
        {

            string data = "This is a test with\n character font B (9 × 17) selected.";
            string printerName = comboInstalledPrinters5.SelectedItem.ToString();
            this.esc.charFontBText(printerName);
            this.esc.printText(printerName, data);
        }

        //Justification example.
        private void button11_Click_1(object sender, EventArgs e)
        {
            string printerName = comboInstalledPrinters5.SelectedItem.ToString();
            //Left justification
            string data = "Left justification...text...\n";          
            this.esc.SelectJustification(printerName, 0);
            this.esc.printText(printerName, data);

            //Centering
            data = "Centering...text...\n";
            this.esc.SelectJustification(printerName, 1);
            this.esc.printText(printerName, data);

            //Right justification
            data = "Right justification...text...\n";
            this.esc.SelectJustification(printerName, 2);
            this.esc.printText(printerName, data);


            //return to normal justification
            this.esc.SelectJustification(printerName, 0);


            feedAndCutter(printerName, 7);


        }

        private void button12_Click(object sender, EventArgs e)
        {
            string printerName = comboInstalledPrinters2.SelectedItem.ToString();

            this.esc.printText(printerName, "EAN13:\n");
            this.esc.barcode_height(printerName, 50);
            this.esc.barcode_width(printerName, 2);
            this.esc.barcodeHRI_chars(printerName);
            this.esc.barcodeHRIPostion(printerName);
            this.esc.printBarcode(printerName, "0123456789012");
            this.esc.lineFeed(printerName, 1);
           
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string printerName = comboInstalledPrinters2.SelectedItem.ToString();
            this.esc.printText(printerName, "EAN8:\n");
            this.esc.barcode_height(printerName, 50);
            this.esc.barcode_width(printerName, 2);
            this.esc.barcodeHRIPostion(printerName);
            this.esc.printBarcode(printerName, "01234567",3);
            this.esc.lineFeed(printerName, 1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
           
            string printerName = comboInstalledPrinters2.SelectedItem.ToString();
            this.esc.printText(printerName, "CODE39:\n");
            this.esc.barcode_height(printerName, 50);
            this.esc.barcode_width(printerName, 2);
            this.esc.barcodeHRI_chars(printerName);
            this.esc.barcodeHRIPostion(printerName);
            this.esc.printBarcode(printerName, "012345678", 4);
            this.esc.lineFeed(printerName, 1);

        }

        private void button15_Click(object sender, EventArgs e)
        {


            string printerName = comboInstalledPrinters2.SelectedItem.ToString();
            this.esc.barcode_height(printerName);
            this.esc.barcodeHRI_chars(printerName);
            this.esc.barcodeHRIPostion(printerName);
            this.esc.printText(printerName, "CODABAR:\n");
            this.esc.printBarcode(printerName, "012345678", 5);
            this.esc.lineFeed(printerName, 1);

            /*
            string printerName = comboInstalledPrinters2.SelectedItem.ToString();
            this.esc.printText(printerName, "CODABAR:\n");
            this.esc.barcode_height(printerName, 70);
            this.esc.barcode_width(printerName, 6);
            this.esc.barcodeHRI_chars(printerName);
            this.esc.barcodeHRIPostion(printerName);
            this.esc.printBarcodeB(printerName, "0134", 71);
            this.esc.lineFeed(printerName, 1);*/
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string printerName = comboInstalledPrinters2.SelectedItem.ToString();
            this.esc.printText(printerName, "CODE128:\n");
            this.esc.barcode_height(printerName,50);
            this.esc.barcode_width(printerName,2);
            this.esc.barcodeHRI_chars(printerName,1);
            this.esc.barcodeHRIPostion(printerName);
          

            //Make sure to specify start character. The start character must be code set selection character (any of CODE
            //A, CODE B, or CODE C) which selects the first code set
            
            //this.esc.printBarcodeB(printerName, "{B012345678901234567", 73);
            //this.esc.printBarcodeB(printerName, "{C012345678901234567", 73); 
            
            this.esc.printBarcodeB(printerName, "{A012345678901234567", 73);
            this.esc.lineFeed(printerName, 1);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string printerName = comboInstalledPrinters6.SelectedItem.ToString();
            //Centering
            this.esc.SelectJustification(printerName, 1);
            //font B
            //this.esc.charFontBText(printerName);
            
            //font A
            this.esc.charFontAText(printerName);

            this.esc.printText(printerName, "\nWhite Party\nData: 01/12/2015\nAbertura:18:00\nLocalAf Lounge\n Feminino\nR$ 0.00 + \nR$ 0.00");
            this.esc.printText(printerName,"\nTeste\nCPF:7060479123");

            //linefeed
            this.esc.lineFeed(printerName, 1);

        //barcode
            this.esc.barcode_height(printerName, 50);
            this.esc.barcode_width(printerName, 2);
            this.esc.barcodeHRIPostion(printerName);
            this.esc.printBarcode(printerName, "6100341928", 3);

            this.esc.printText(printerName, "\nCID:31BH283Z8892042");

            //line feed
            this.esc.lineFeed(printerName, 2);
            this.esc.printText(printerName, "\nClassificação: 18 anos\nproibida a entrada com boné e regata");

        }

        private void button18_Click(object sender, EventArgs e)
        {


            string printerName = comboInstalledPrinters2.SelectedItem.ToString();
            this.esc.printText(printerName, "ITF:\n");
            this.esc.barcode_height(printerName, 50);
            this.esc.barcode_width(printerName, 2);
            this.esc.barcodeHRI_chars(printerName);
            this.esc.barcodeHRIPostion(printerName);
            this.esc.printBarcode(printerName, "012345678", 5);
            this.esc.lineFeed(printerName, 1);

        }

        private void button19_Click(object sender, EventArgs e)
        {
            string printerName = comboInstalledPrinters2.SelectedItem.ToString();
            this.esc.printText(printerName, "CODE 93 :\n");
            this.esc.barcode_height(printerName, 50);
            this.esc.barcode_width(printerName, 2);
            this.esc.barcodeHRI_chars(printerName, 1);
            this.esc.barcodeHRIPostion(printerName);

            this.esc.printBarcodeB(printerName, "123456789", 72);
            
            this.esc.lineFeed(printerName, 1);
          
        }

    }


}
