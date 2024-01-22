using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Chapter.Command
{
    public abstract class Command
    {
        public abstract void Execute();
    }
    public class TurnLeft : Command
    {
        private PlayerMovement _controller;
        public TurnLeft(PlayerMovement controller)
        {
            _controller = controller;
        }
        public override void Execute()
        {
            _controller.Turn(PlayerMovement.Direction.Left);
        }
    }
    public class TurnRight : Command
    {
        private PlayerMovement _controller;
        public TurnRight(PlayerMovement controller)
        {
            _controller = controller;
        }
        public override void Execute()
        {
            _controller.Turn(PlayerMovement.Direction.Right);
        }
    }
}
