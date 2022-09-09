using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventQueueManager : MonoBehaviour
{
    //Singleton
    static public EventQueueManager instance; 

    public List<ICommand> Events => _events;
    private List<ICommand> _events = new List<ICommand>(); 

    private void Awake() 
    { 
        if (instance != null) Destroy(this); 
        instance = this;
    }

    private void Update() 
    { 
        foreach (ICommand command in _events)
        {
            command.Execute(); 
        }
        _events.Clear(); // lo va limpiando en cada frame
    }

    public void AddCommand(ICommand command) => _events.Add(command);
}
