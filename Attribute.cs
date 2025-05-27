namespace EntityOOP;


public abstract class Attribute {
    // FIELDS
    private float current;
    private float maximum;
    
    
    // PROPERTIES
    public float Current { get => current; protected set => current = value; }
    public float Maximum { get => maximum; protected set => maximum = value; }
    
    
    // CONSTRUCTOR
    public Attribute(float maximum) {
        Current = maximum;
        Maximum = maximum;
    }


    // METHODS
    public void Display() {
        Console.WriteLine("[" + GetType().Name.ToUpper() + "] " + Current + "/" + Maximum);
        AttrBar();
    }

    public virtual void Increase(float amount) {
        Current += amount;
    }

    public virtual void Decrease(float amount) {
        Current -= amount;
    }

    private void AttrBar() {
        float maxLength = 20f;
        int filledLength = (int) (Current / Maximum *  maxLength);
        int emptyLength = (int) maxLength - filledLength;
        int attrPercent = (int) (Current / Maximum * 100);
        
        Console.Write(attrPercent + "%\t");
        for (int i = 0; i < filledLength; i++) {
            Console.Write("|");
        }
        for (int i = 0; i < emptyLength; i++) {
            Console.Write("-");
        }
        Console.WriteLine();
    }
}