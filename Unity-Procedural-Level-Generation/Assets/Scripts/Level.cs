using System.Collections.Generic;

public class Level
{
    private int width;
    private int length;
    private List<Hallway> hallways;
    private List<Room> rooms;

    public int Width { get { return width; } }
    public int Length { get { return length; } }

    public Level(int width, int length) {
        this.width = width;
        this.length = length;
        rooms = new List<Room>();
        hallways = new List<Hallway>();
    }
}
