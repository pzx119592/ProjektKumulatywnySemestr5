using System;
using System.Collections.Generic;

// --- Interfejsy ---
// Zadanie 2: Interfejsy i abstrakcja
public interface IAnswer
{
    string Text { get; set; }
    bool IsCorrect { get; set; }
}

public interface IQuestion<TAnswer>
{
    string Text { get; set; }
    List<TAnswer> Answers { get; }
}

public interface IQuiz<TQuestion, TAnswer>
{
    string Title { get; set; }
    List<TQuestion> Questions { get; }
}

// --- Klasy ---
// Zadanie 1: Programowanie obiektowe
public class Answer : IAnswer
{
    public string Text { get; set; }
    public bool IsCorrect { get; set; }
}

public class Question<TAnswer> : IQuestion<TAnswer>
{
    public string Text { get; set; }
    public List<TAnswer> Answers { get; set; }

    public Question()
    {
        Answers = new List<TAnswer>();
    }
}

public class Quiz<TQuestion, TAnswer> : IQuiz<TQuestion, TAnswer>
{
    public string Title { get; set; }
    public List<TQuestion> Questions { get; set; }

    public Quiz()
    {
        Questions = new List<TQuestion>();
    }
}

// --- Generyczny magazyn danych ---
// Zadanie 3: Generyki – zarządzanie danymi związanymi z quizami
public class DataStore<T>
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public List<T> GetAll()
    {
        return items;
    }
}

// --- Program główny ---
class Program
{
    static void Main()
    {
        // W tej wersji nie ma logiki quizu ani wypisywania na konsolę.
        // Program zawiera tylko definicje klas, interfejsów i generyków.
    }
}


// TEST