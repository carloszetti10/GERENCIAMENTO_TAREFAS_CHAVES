using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace GERENC_WPF.Helper
{
    public static class PasswordBoxHelper
    {
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.RegisterAttached(
                "Password",
                typeof(string),
                typeof(PasswordBoxHelper),
                new FrameworkPropertyMetadata(string.Empty));

        public static string GetPassword(DependencyObject obj)
            => (string)obj.GetValue(PasswordProperty);

        public static void SetPassword(DependencyObject obj, string value)
            => obj.SetValue(PasswordProperty, value);

        public static readonly DependencyProperty BindPasswordProperty =
            DependencyProperty.RegisterAttached(
                "BindPassword",
                typeof(bool),
                typeof(PasswordBoxHelper),
                new PropertyMetadata(false, OnBindPasswordChanged));

        public static bool GetBindPassword(DependencyObject obj)
            => (bool)obj.GetValue(BindPasswordProperty);

        public static void SetBindPassword(DependencyObject obj, bool value)
            => obj.SetValue(BindPasswordProperty, value);

        private static void OnBindPasswordChanged(
            DependencyObject d,
            DependencyPropertyChangedEventArgs e)
        {
            if (d is PasswordBox pb)
            {
                pb.PasswordChanged -= PasswordChanged;

                if ((bool)e.NewValue)
                    pb.PasswordChanged += PasswordChanged;
            }
        }

        private static void PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (sender is PasswordBox pb)
            {
                SetPassword(pb, pb.Password);
            }
        }
    }
}
