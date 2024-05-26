

namespace CheesClassDiagram.Models;

    public interface IPiece
    {
        bool Killed { get; set; }
        bool IsWhite();
        bool IsKilled();
        bool CanMove();


}

