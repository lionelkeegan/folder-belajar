public class Empty : Piece
{
    int position;

    public override string Value()
    {
        return position.ToString();
    }
}