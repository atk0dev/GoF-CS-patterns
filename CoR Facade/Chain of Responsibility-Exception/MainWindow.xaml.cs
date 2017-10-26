﻿using System;
using System.Windows;

namespace Chain_of_Responsibility_Exceptions
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickMeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Method1();

            }
            catch (ArgumentException)
            {
                TextBlock1.Text = "Caught in Click";
            }
        }

        private void Method1()
        {
            try
            {
                Method2();

            }
            catch (NullReferenceException)
            {
                TextBlock1.Text = "Caught in Method 1";
            }
        }

        private void Method2()
        {
            try
            {
                switch (ExceptionBox.Text)
                {
                    case "AccessViolationException":
                        throw new AccessViolationException();
                    case "NullReferenceException":
                        throw new NullReferenceException();
                    case "ArgumentException":
                        throw new ArgumentException();
                    case "Exception":
                        throw new Exception();
                }

            }
            catch (AccessViolationException)
            {
                TextBlock1.Text = "Caught in Method2";
            }
        }
    }
}
