using System;
using EntityFrameworkCore.Triggers;

public abstract class Trackable
{
    public DateTime CreatedDate { get; private set; }
    public DateTime UpdatedDate { get; private set; }

    static Trackable()
    {
        Triggers<Trackable>.Inserting += entry => entry.Entity.CreatedDate = entry.Entity.CreatedDate = DateTime.Now;
        Triggers<Trackable>.Updating += entry => entry.Entity.UpdatedDate = DateTime.Now;
    }
}