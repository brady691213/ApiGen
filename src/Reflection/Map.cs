﻿namespace Reflection;

/// <summary>
/// A bidirectional map between any two types.
/// </summary>
/// <remarks>
/// Found at: https://stackoverflow.com/a/10966684/8741. No real use yet, 2 dictionary approach is fine.
/// </remarks>
public class Map<T1, T2> where T1 : notnull
{
    // TASKT: Check out then follow up suggestions.
    
    private readonly Dictionary<T1, T2> _forward = new();
    private readonly Dictionary<T2, T1> _reverse = new();

    public Map()
    {
        Forward = new Indexer<T1, T2>(_forward);
        Reverse = new Indexer<T2, T1>(_reverse);
    }

    public class Indexer<T3, T4>
    {
        private readonly Dictionary<T3, T4> _dictionary;
        
        public Indexer(Dictionary<T3, T4> dictionary)
        {
            _dictionary = dictionary;
        }
        
        public T4 this[T3 index]
        {
            get => _dictionary[index];
            set => _dictionary[index] = value;
        }
    }

    public void Add(T1 t1, T2 t2)
    {
        _forward.Add(t1, t2);
        _reverse.Add(t2, t1);
    }

    public Indexer<T1, T2> Forward { get; private set; }
    public Indexer<T2, T1> Reverse { get; private set; }
}