namespace video_deep_learning
{
    public class Monster
    {
        private int x,y;

        private void Move(Direction direction){
            switch(direction)
            {
                case Direction.UP:
                    y+=1;
                    break;
                case Direction.DOWN:
                    y-=1;
                    break;
                case Direction.LEFT:
                    x-=1;
                    break;
                case Direction.RIGHT:
                    x+=1;
                    break;
            }
        }
    }
}