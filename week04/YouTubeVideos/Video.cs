using System;
using System.Transactions;
using System.Collections.Generic;


public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;


    public Video(string title, int length)
    {
        _title = title;
        _author = "unknown";
        _length = length;
        _comments = new List<Comment>();
    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"Video: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Video length in seconds: {_length}");
        Console.WriteLine($"Number of comments: {NumberOfComments()}");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
        }
    }
}