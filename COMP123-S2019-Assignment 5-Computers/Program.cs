using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMP123_S2019_Assignment_5_Computers.Views;
using COMP123_S2019_Assignment_5_Computers.Models;

/*
 * Name : Chuyun Yang
 * Student : 301038102
 * Date : 2019/08/01
 * Description : Create a multi-form project that simulates a computer purchase.
 * Version : Ver_01-GUI
 */


namespace COMP123_S2019_Assignment_5_Computers
{
    public static class Program
    {
        //static members
        public static SplashForm splashForm;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;
        public static AboutForm aboutForm;

        public static Product product;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //instanticate all forms here
            splashForm = new SplashForm();
            startForm = new StartForm();
            selectForm = new SelectForm();
            productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();
            aboutForm = new AboutForm();

            product = new Product();

            Application.Run(splashForm);
        }
    }
}
