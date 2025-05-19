using UnityEngine;

public class LayoutGeneratorRooms : MonoBehaviour
{
    [SerializeField] private int width = 64;
    [SerializeField] private int length = 64;

    [SerializeField] private int roomWidthMin = 3;
    [SerializeField] private int roomWidthMax = 5;
    [SerializeField] private int roomLengthMin = 3;
    [SerializeField] private int roomLengthMax = 5;

    System.Random random;

    [ContextMenu("Generate Level Layout")]
    public void GenerateLevel() {
        random = new System.Random();
        var roomRect = GetStartRoomRect();
        Debug.Log(roomRect);
    }

    private RectInt GetStartRoomRect() {
        int roomWidth = random.Next(roomWidthMin, roomWidthMax);
        int availableWidthX = width / 2 - roomWidth;
        int randomX = random.Next(0, availableWidthX);
        int roomX = randomX + (width / 4);

        int roomLength = random.Next(roomLengthMin, roomLengthMax);
        int availableLengthY = length / 2 - roomLength;
        int randomY = random.Next(0,availableLengthY);
        int roomY = randomY + (length / 4);

        return new RectInt(roomX, roomY, roomWidth, roomLength);
    }
}
