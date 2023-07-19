using System;
using System.Collections.Generic;

class Video
{
    public string Title { get; }
    public string Author { get; }
    public int Length { get; }
    private List<Comment> comments;

    public Video(string _title, string _author, int _length)
    {
        Title = _title;
        Author = _author;
        Length = _length;
        comments = new List<Comment>();
    }

    public void AddComment(string _name, string _text)
    {
        Comment comment = new Comment(_name, _text);
        comments.Add(comment);
    }

    public int GetNumComments()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}