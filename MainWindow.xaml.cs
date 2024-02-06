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
        double hprogbuffer = 0;
        double hpwizbuffer = 0;
        double manarogbuffer = 0;
        double manawizbuffer = 0.5;
        int tokens = 0;
        double WarCrtChanceBuf;
        double RogCrtChanceBuf;
        double WizCrtChanceBuf;

        Warrior warrior = new Warrior();
        Rogue rogue = new Rogue();
        Wizard wizard = new Wizard();

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
                    StrengthBaseLabel.Content = wizard.strength;
                    DexterityBaseLabel.Content = wizard.dexterity;
                    IntelligenceBaseLabel.Content = wizard.inteligence;
                    VitalityBaseLabel.Content = wizard.vitality;

                    StrengthNowLabel.Content = wizard.strength;
                    DexterityNowLabel.Content = wizard.dexterity;
                    IntelligenceNowLabel.Content = wizard.inteligence;
                    VitalityNowLabel.Content = wizard.vitality;

                    Health.Content = wizard.health;
                    Mana.Content = wizard.mana;
                    break;
                case "Warrior":
                    Warrior warrior = new Warrior();
                    StrengthBaseLabel.Content = warrior.strength;
                    DexterityBaseLabel.Content = warrior.dexterity;
                    IntelligenceBaseLabel.Content = warrior.inteligence;
                    VitalityBaseLabel.Content = warrior.vitality;

                    StrengthNowLabel.Content = warrior.strength;
                    DexterityNowLabel.Content = warrior.dexterity;
                    IntelligenceNowLabel.Content = warrior.inteligence;
                    VitalityNowLabel.Content = warrior.vitality;

                    Health.Content = warrior.health;
                    Mana.Content = warrior.mana;
                    break;
                case "Rogue":
                    Rogue rogue = new Rogue();
                    StrengthBaseLabel.Content = rogue.strength;
                    DexterityBaseLabel.Content = rogue.dexterity;
                    IntelligenceBaseLabel.Content = rogue.inteligence;
                    VitalityBaseLabel.Content = rogue.vitality;

                    StrengthNowLabel.Content = rogue.strength;
                    DexterityNowLabel.Content = rogue.dexterity;
                    IntelligenceNowLabel.Content = rogue.inteligence;
                    VitalityNowLabel.Content = rogue.vitality;

                    Health.Content = rogue.health;
                    Mana.Content = rogue.mana;
                    break;
            }
        }

        private void StrengthBtn_Click(object sender, RoutedEventArgs e)
        {
            string textFromTextBox = ВalanceTextBox.Text;

            if (int.TryParse(textFromTextBox, out int balance))
            {
                balance--;
                ВalanceTextBox.Text = balance.ToString();
                if (balance < 0)
                {
                    MessageBox.Show("недостаточно поинтов");
                }

                int labelValue;
                if (int.TryParse(StrengthNowLabel.Content.ToString(), out labelValue))
                {
                    labelValue++;
                    StrengthNowLabel.Content = labelValue.ToString();
                    if(labelValue >)
                }

                if (UserComboBox.SelectedItem.ToString() == "Warrior")
                {
                    if (balance > 0)
                    {
                        warrior.health++;
                        Health.Content = warrior.health;
                    }
                    else
                    {
                        MessageBox.Show("Баланс пуст");
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное число в поле для баланса.");
            }

        }
    }
}
