using DesignPatterns.Extensions;
using System.ComponentModel;

namespace DesignPatterns.BehavioralPatterns.Memento.Examples.CheckPointer
{
    /// <summary>
    /// Orginator Class
    /// </summary>
    public class PersonAction
    {
        string message;
        public string Messages
        {
            get => $"{message}";
            set
            {
                message = value;
                Console.WriteLine($"Action {action.GetDescription()}");
            }
        }

        ActionRadarType action;
        public int Action
        {
            get => (int)action;
            set
            {
                action = (ActionRadarType)value;
            }
        }
        public PersonRadar CreatePersonRadar()
        {
            Console.WriteLine($"CreatePersonRadar : {Messages}");
            return new PersonRadar(message, (int)action);
        }
        public void SetPersonRadar(PersonRadar personRadar)
        {
            Console.WriteLine($"SetMemento ...");
            Messages = personRadar.Message;
            action = (ActionRadarType)personRadar.Action;
        }
    }
    /// <summary>
    /// Memento Class
    /// </summary>
    public class PersonRadar
    {
        int action;
        string message;
        public PersonRadar(string message, int action)
        {
            this.message = message;
            this.action = action;
        }
        public string Message
        {
            get => message;
        }
        public int Action
        {
            get => action;
        }
    }
    /// <summary>
    /// Caretaker Class
    /// </summary>
    public class ActionRadarManager
    {
        PersonRadar Radar;
        public PersonRadar PersonRadar
        {
            get => Radar;
            set => Radar = value;
        }
    }
    enum ActionRadarType
    {
        [Description("Stop")]
        None = 0,
        [Description("Up")]
        Up,
        [Description("Down")]
        Down,
        [Description("Right")]
        Right,
        [Description("Left")]
        Left
    }
}
