using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BestGameDD
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Wizard wizard = new Wizard();
        Warrior warrior = new Warrior();
        Rogue rogue = new Rogue();
        public MainWindow()
        {
            InitializeComponent();

        }
      
        private void UserComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)UserComboBox.SelectedItem;
            string selectedClass = selectedItem.Content.ToString();
           
            switch (selectedClass)
            {
                case "Wizard":
                    Wizard wizard = new Wizard();
                    StrengthBaseLabel.Content = wizard.Strength;
                    DexterityBaseLabel.Content = wizard.Dexterity;
                    IntelligenceBaseLabel.Content = wizard.Intelligence;
                    VitalityBaseLabel.Content = wizard.Vitality;
                    
                    StrengthNowLabel.Content = wizard.Strength;
                    DexterityNowLabel.Content = wizard.Dexterity;
                    IntelligenceNowLabel.Content = wizard.Intelligence;
                    VitalityNowLabel.Content = wizard.Vitality;
                    break;
                case "Warrior":
                    Warrior warrior = new Warrior();
                    StrengthBaseLabel.Content = warrior.Strength;
                    DexterityBaseLabel.Content = warrior.Dexterity;
                    IntelligenceBaseLabel.Content = warrior.Intelligence;
                    VitalityBaseLabel.Content = warrior.Vitality;

                    StrengthNowLabel.Content = warrior.Strength;
                    DexterityNowLabel.Content = warrior.Dexterity;
                    IntelligenceNowLabel.Content = warrior.Intelligence;
                    VitalityNowLabel.Content = warrior.Vitality;
                    break;
                case "Rogue":
                    Rogue rogue = new Rogue();
                    StrengthBaseLabel.Content = rogue.Strength;
                    DexterityBaseLabel.Content = rogue.Dexterity;
                    IntelligenceBaseLabel.Content = rogue.Intelligence;
                    VitalityBaseLabel.Content = rogue.Vitality;

                    StrengthNowLabel.Content = rogue.Strength;
                    DexterityNowLabel.Content = rogue.Dexterity;
                    IntelligenceNowLabel.Content = rogue.Intelligence;
                    VitalityNowLabel.Content = rogue.Vitality;
                    break;
            }

            
        }

        private void StrengthBtn_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)UserComboBox.SelectedItem;
            string selectedClass = selectedItem.Content.ToString();
            if (selectedClass == "Warrior")
            {
                MessageBox.Show("vgvuygvgy");
                warrior.Strength += 2;
                StrengthNowLabel.Content = warrior.Strength;
            }

            

        }

        private void ВalanceTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
