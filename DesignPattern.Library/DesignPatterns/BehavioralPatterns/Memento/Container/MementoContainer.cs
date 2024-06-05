using DesignPatterns.BehavioralPatterns.Memento.Examples.CheckPointer;
using DesignPatterns.BehavioralPatterns.Memento.Pattern;

namespace DesignPatterns.BehavioralPatterns.Memento.Container
{
    public class MementoContainer
    {
        public void Pattern()
        {
            Orginator orginator = new Orginator();
            orginator.State = "Green";
            Caretaker caretaker = new Caretaker();
            caretaker.Memento = orginator.CreateMemento();
            orginator.State = "Red";
            orginator.State = "Yellow";
            orginator.State = "Blue";

            orginator.SetMemento(caretaker.Memento);
        }

        public void PersonActionExample()
        {
            PersonAction action = new PersonAction();
            action.Action = 3;
            action.Messages = $"Goto {(ActionRadarType)action.Action}";

            ActionRadarManager manager = new ActionRadarManager();
            manager.PersonRadar = action.CreatePersonRadar();
            action.Action = 1;
            action.Messages = $"Goto {(ActionRadarType)action.Action}";
            manager.PersonRadar = action.CreatePersonRadar();

            action.Action = 2;
            action.Messages = $"Goto {(ActionRadarType)action.Action}";
            action.SetPersonRadar(manager.PersonRadar);
            manager.PersonRadar = action.CreatePersonRadar();

            action.Action = 2;
            action.Messages = $"Goto {(ActionRadarType)action.Action}";
            manager.PersonRadar = action.CreatePersonRadar();
        }
        public void Execute()
        {

        }
    }
}
