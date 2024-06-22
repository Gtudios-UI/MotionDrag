namespace Gtudios.UI.MotionDrag;
public delegate void MotionDragConnectionDraggingOutside<TItem>(object? sender, TItem item, DragPosition dragPosition);
public delegate void MotionDragConnectionDroppedOutside<TItem>(object? sender, TItem item, DragPosition dragPosition, DropManager dropManager);