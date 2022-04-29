using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shifri
{
	
	    public partial class Form1 : Form{
        public Form1() 
        {
			InitializeComponent();
		}
        const String eng1 = "abcdefghijklmnopqrstuvwxyz";
        const String eng2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const String rus1 = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        const String rus2 = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        String strIn = ""; String strOut = ""; String s, s1, key; int c, k = 1, count; bool check, checkKey;
        private void Button1Click(object sender, EventArgs e)
        { 																								//Шифровать по Цезарю
            strIn = textBox1.Text;
            strOut = "";
            check = true;
            for (int i = 0; i < strIn.Length; i++)
            {
                s = strIn[i].ToString();
                if (eng1.Contains(s))
                {
                    c = eng1.IndexOf(s) + k % eng1.Length;
                    if (c >= eng1.Length)
                        c = c - eng1.Length;
                    strOut += eng1[c];
                }
                else if (eng2.Contains(s))
                {
                    c = eng2.IndexOf(s) + k % eng2.Length;
                    if (c >= eng2.Length)
                        c = c - eng2.Length;
                    strOut += eng2[c];
                }
                else if (rus1.Contains(s))
                {
                    c = rus1.IndexOf(s) + k % rus1.Length;
                    if (c >= rus1.Length)
                        c = c - rus1.Length;
                    strOut += rus1[c];}
                else if (rus2.Contains(s))
                {
                    c = rus2.IndexOf(s) + k % rus2.Length;
                    if (c >= rus2.Length)
                        c = c - rus2.Length;
                    strOut += rus2[c];
                }
                else if (s == " ")
                    strOut += " ";
                else
                {
                    check = false;
                    break;
                }
            }
            if (check == true)
                textBox2.Text = strOut;
            else
            {
                MessageBox.Show("Неверный формат вводимого сообщения / Invalid message format");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
        private void Button2Click(object sender, EventArgs e)
        {																				 //Дешифрование по Цезарю
            strOut = textBox2.Text;
            strIn = "";
            check = true;
            for (int i = 0; i < strOut.Length; i++)
            {
                s = strOut[i].ToString();
                if (eng1.Contains(s))
                {
                    c = eng1.IndexOf(s) - k % eng1.Length;
                    if (c < 0)
                        c = c + eng1.Length;
                    strIn += eng1[c];
                }
                else if (eng2.Contains(s))
                {
                    c = eng2.IndexOf(s) - k % eng2.Length;
                    if (c < 0)
                        c = c + eng2.Length;
                    strIn += eng2[c];}
                else if (rus1.Contains(s)){
                    c = rus1.IndexOf(s) - k % rus1.Length;
                    if (c < 0)
                        c = c + rus1.Length;
                    strIn += rus1[c];
                }
                else if (rus2.Contains(s))
                {
                    c = rus2.IndexOf(s) - k % rus2.Length;
                    if (c < 0)
                        c = c + rus2.Length;
                    strIn += rus2[c];
                }
                else if (s == " ")
                    strIn += " ";
                else
                {
                    check = false;
                    break;
                }
            }
            if (check == true)
                textBox1.Text = strIn;
            else
            {
                MessageBox.Show("Неверный формат вводимого сообщения / Invalid message format");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
        private void Button3Click(object sender, EventArgs e) 
        {
        	//Шифрование по Виженеру
            key = textBox3.Text;
            strIn = textBox4.Text;
            strOut = "";
            count = 0;
            check = true;
            checkKey = true;
            if (key.Length == 0)
                checkKey = false;
            for (int i =0; i > key.Length; i++)
            {
                if (!(eng1.Contains(key) || eng2.Contains(key) || rus1.Contains(key) || rus2.Contains(key)))
                {
                    checkKey = false;
                    break;
            	}
            }
            if (checkKey == true)
            {
                for (int i = 0; i < strIn.Length; i++)
                {
                    s = strIn[i].ToString();
                    if (count == key.Length)
                        count = 0;
                    s1 = key[count].ToString();
                    if (eng1.Contains(s)){
                        if (eng1.Contains(s1))
                            c = (eng1.IndexOf(s) + eng1.IndexOf(s1)) % eng1.Length;
                        else if (eng2.Contains(s1))
                            c = (eng1.IndexOf(s) + eng2.IndexOf(s1)) % eng1.Length;
                        else
                        {
                            check = false;
                            break;
                        }
                        if (c > eng1.Length)
                            c = c - eng1.Length;
                        strOut += eng1[c];
                    }
                    else if (eng2.Contains(s))
                    {
                        if (eng1.Contains(s1))
                            c = (eng2.IndexOf(s) + eng1.IndexOf(s1)) % eng2.Length;
                        else if (eng2.Contains(s1))
                            c = (eng2.IndexOf(s) + eng2.IndexOf(s1)) % eng2.Length;
                        else
                        {
                            check = false;
                            break; 
                        }
                        if (c > eng2.Length)
                            c = c - eng2.Length;
                        strOut += eng2[c];
                    }
                    else if (rus1.Contains(s))
                    {
                        if (rus1.Contains(s1))
                            c = (rus1.IndexOf(s) + rus1.IndexOf(s1)) % rus1.Length;
                        else if (rus2.Contains(s1))
                            c = (rus1.IndexOf(s) + rus2.IndexOf(s1)) % rus1.Length;
                        else
                        {
                            check = false;
                            break;
                        }
                        if (c > rus1.Length)
                            c = c - rus1.Length;
                        strOut += rus1[c];}
                    else if (rus2.Contains(s))
                    {
                        if (rus1.Contains(s1))
                            c = (rus2.IndexOf(s) + rus1.IndexOf(s1)) % rus2.Length;
                        else if (rus2.Contains(s1))
                            c = (rus2.IndexOf(s) + rus2.IndexOf(s1)) % rus2.Length;
                        else
                        {
                            check = false;
                            break;
                        }
                        if (c > rus2.Length)
                            c = c - rus2.Length;
                        strOut += rus2[c];
                    }
                    
                    else if (s == " "){
                        strOut += " ";
                        count--;}
                    else{
                        check = false;
                        break;}
                    count++;}
                if (check == true)
                    textBox5.Text = strOut;
                else{
                    MessageBox.Show("Неверный формат вводимого сообщения / Invalid message format");
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
            }
            else{
                MessageBox.Show("Неверный формат ключа / Invalid key format");
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }
        private void Button4Click(object sender, EventArgs e) {//Дешифрование по Виженеру
            key = textBox3.Text;
            strOut = textBox5.Text;
            strIn = "";
            count = 0;
            check = true;
            checkKey = true;
            if (key.Length == 0)
                checkKey = false;
            for (int i = 0; i > key.Length; i++){
                if (!(eng1.Contains(key) || eng2.Contains(key) || rus1.Contains(key) || rus2.Contains(key))){
                    checkKey = false;
                    break;}}
            if (checkKey == true){
                for (int i = 0; i < strOut.Length; i++){
                    s = strOut[i].ToString();
                    if (count == key.Length)
                        count = 0;
                    s1 = key[count].ToString();
                    if (eng1.Contains(s)){
                        if (eng1.Contains(s1))
                            c = (eng1.IndexOf(s) - eng1.IndexOf(s1) + eng1.Length) % eng1.Length;
                        else if (eng2.Contains(s1))
                            c = (eng1.IndexOf(s) - eng2.IndexOf(s1) + eng1.Length) % eng1.Length;
                        else{
                            check = false;
                            break;}
                        if (c > eng1.Length)
                            c = c - eng1.Length;
                        strIn += eng1[c];}
                    else if (eng2.Contains(s)){
                        if (eng1.Contains(s1))
                  c = (eng2.IndexOf(s) - eng1.IndexOf(s1) + eng2.Length) % eng2.Length;
                        else if (eng2.Contains(s1))
                  c = (eng2.IndexOf(s) - eng2.IndexOf(s1) + eng2.Length) % eng2.Length;
                        else{
                            check = false;
                            break;}
                        if (c > eng2.Length)
                            c = c - eng2.Length;
                        strIn += eng2[c];}
                    else if (rus1.Contains(s)){
                        if (rus1.Contains(s1))
                     c = (rus1.IndexOf(s) - rus1.IndexOf(s1) + rus1.Length) % rus1.Length;
                        else if (rus2.Contains(s1))
                     c = (rus1.IndexOf(s) - rus2.IndexOf(s1) + rus1.Length) % rus1.Length;
                        else{
                            check = false;
                            break;}
                        if (c > rus1.Length)
                            c = c - rus1.Length;
                        strIn += rus1[c];}
                    else if (rus2.Contains(s)){
                        if (rus1.Contains(s1))
                     c = (rus2.IndexOf(s) - rus1.IndexOf(s1) + rus2.Length) % rus2.Length;
                        else if (rus2.Contains(s1))
                     c = (rus2.IndexOf(s) - rus2.IndexOf(s1) + rus2.Length) % rus2.Length;
                        else{
                            check = false;
                            break;}
                        if (c > rus2.Length)
                            c = c - rus2.Length;
                        strIn += rus2[c];}
                    else if (s == " "){
                        strIn += " ";
                        count--;}
                    else{
                        check = false;
                        break;}
                    count++;}
            	                if (check == true)
                    textBox4.Text = strIn;
                else{
                    MessageBox.Show("Неверный формат вводимого сообщения / Invalid message format");
                    textBox4.Text = "";
                    textBox5.Text = "";}}
            else{
                MessageBox.Show("Неверный формат ключа / Invalid key format");
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

             }
      
        }
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
	
		}
		
		void TextBox3TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox4TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox5TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button6Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
		}
		void Button5Click(object sender, EventArgs e)
		{
			textBox3.Text = "";
			textBox4.Text = "";
			textBox5.Text = "";
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
	
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
	}
}
