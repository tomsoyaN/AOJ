using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAOJ
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
            //コンパイラ起動
            //二つ目の引数はコンパイルしたいcppファイルの保存場所およびファイル名
            //a.exeは\AOJ\ProjectAOJ\ProjectAOJ\bin\Debugに保存される模様
            System.Diagnostics.Process.Start("g++", @"C:\Users\Owner\source\repos\AOJ\ProjectAOJ\ProjectAOJ\bin\Debug\test.cpp");
            //生成された実行ファイルを実行
            //二つ目の引数は実行したいexeファイルの保存場所およびファイル名
            //System.Diagnostics.Process.Start("a.exe", @"C:\Users\Owner\source\repos\AOJ\ProjectAOJ\ProjectAOJ\bin\Debug\a.exe");

        }
    }
}

// 本日は晴天なり
