namespace knightmoves;

public class FileManager{

    public void Create(string fileName){
        System.IO.File.WriteAllText(fileName, "file hello");
    }
}
