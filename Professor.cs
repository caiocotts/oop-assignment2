namespace Assignment2;

public class Professor {
    private static int profCounter;
    private int profID;
    private string name;
    private string[] coursesTaught;

    public Professor(string name, string[] coursesTaught) {
        this.name = name;
        this.coursesTaught = coursesTaught;
        profCounter++;
        profID = profCounter;
    }
}