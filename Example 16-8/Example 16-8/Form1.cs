using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//---main name space-------------------------------
namespace Example_16_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //-------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode node1 = new TreeNode("BackColorRed()");
            TreeNode node2 = new TreeNode("Text_MH()");
            TreeNode nodeClass11 = new TreeNode("Class11");
            nodeClass11.Nodes.Add(node1);
            nodeClass11.Nodes.Add(node2);
            TreeNode node3 = new TreeNode("BackColorBlue()");
            TreeNode node4 = new TreeNode("Width500()");
            TreeNode nodeClass12 = new TreeNode("Class12");
            nodeClass12.Nodes.Add(node3);
            nodeClass12.Nodes.Add(node4);
            TreeNode nodeNamespace1 = new TreeNode("NameSpace1");
            nodeNamespace1.Nodes.Add(nodeClass11);
            nodeNamespace1.Nodes.Add(nodeClass12);
            treeView1.Nodes.Add(nodeNamespace1);
            //+++++++++++++++++++++++++++++++++++++++++++++//
            TreeNode node5 = new TreeNode("Height800()");
            TreeNode node6 = new TreeNode("Opacity80()");
            TreeNode nodeClass21 = new TreeNode("Class21");
            nodeClass21.Nodes.Add(node5);
            nodeClass21.Nodes.Add(node6);
            TreeNode node7 = new TreeNode("Opacity100()");
            TreeNode node8 = new TreeNode("Maximize()");
            TreeNode nodeClass22 = new TreeNode("Class22");
            nodeClass22.Nodes.Add(node7);
            nodeClass22.Nodes.Add(node8);
            TreeNode nodeNamespace2 = new TreeNode("NameSpace2");
            nodeNamespace2.Nodes.Add(nodeClass21);
            nodeNamespace2.Nodes.Add(nodeClass22);
            treeView1.Nodes.Add(nodeNamespace2);
            //++++++++++++//
            treeView1.ExpandAll();
        }
        //-------------------------------------------------------------------
        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            switch (treeView1.SelectedNode.Text)
            {
                case "BackColorRed()":
                    NameSpace1.Class11.BackColorRed(this);
                    break;
                case "Text_MH()":
                    NameSpace1.Class11.Text_MH(this);
                    break;
                case "BackColorBlue()":
                    NameSpace1.Class12.BackColorBlue(this);
                    break;
                case "Width500()":
                    NameSpace1.Class12.Width500(this);
                    break;
                case "Height800()":
                    NameSpace2.Class21.Height800(this);
                    break;
                case "Opacity80()":
                    NameSpace2.Class21.Opacity80(this);
                    break;
                case "Opacity100()":
                    NameSpace2.Class22.Opacity100(this);
                    break;
                case "Maximize()":
                    NameSpace2.Class22.Maximize(this);
                    break;
            }
        }
    }
}
//-------namespace1--------------------------------
namespace NameSpace1
{
    public static class Class11
    {
        public static void BackColorRed(Form f)
        {
            f.BackColor = Color.Red;
        }
        public static void Text_MH(Form f)
        {
            f.Text = "MH";
        }
    }
    public static class Class12
    {
        public static void BackColorBlue(Form f)
        {
            f.BackColor = Color.Blue;
        }
        public static void Width500(Form f)
        {
            f.Width = 500;
        }
    }
}
//-------namespace2--------------------------------
namespace NameSpace2
{
    public static class Class21
    {
        public static void Height800(Form f)
        {
            f.Height = 800;
        }
        public static void Opacity80(Form f)
        {
            f.Opacity = 0.8;
        }
    }
    public static class Class22
    {
        public static void Opacity100(Form f)
        {
            f.Opacity = 1;
        }
        public static void Maximize(Form f)
        {
            f.WindowState = FormWindowState.Maximized;
        }
    }
}

