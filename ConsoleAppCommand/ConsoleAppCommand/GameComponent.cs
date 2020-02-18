namespace ConsoleAppCommand
{
    /// <summary>
    /// Fake Game Componenet
    /// </summary>

    public class GameComponent
    {
        private int _X, _Y, _Z;

        public int X { get { return this._X; } protected set { _X = value; } }

        public int Y { get { return this._Y; } protected set { _Y = value; } }

        public int Z { get { return this._Z; } protected set { _Z = value; } }

        internal void MoveUp()
        {
            this.Y++;
        }
        internal void MoveDown()
        {
            this.Y--;
        }
        internal void MoveRight()
        {
            this.X++;
        }
        internal void MoveLeft()
        {
            this.X--;
        }

        internal void Dig()
        {
            this.Z--;
        }

        internal void Place()
        {
            this.Z++;
        }
    }
}