// machine generated on 10/24/2008 3:54:06 PM using /System/Library/Frameworks/AppKit.framework/Versions/Current/Headers/NSDragging.h

using MObjc;
using System;

namespace MCocoa
{
	public partial class Enums
	{
		public const int NSDragOperationNone = 0;
		public const int NSDragOperationCopy = 1;
		public const int NSDragOperationLink = 2;
		public const int NSDragOperationGeneric = 4;
		public const int NSDragOperationPrivate = 8;
		public const int NSDragOperationAll_Obsolete = 15;
		public const int NSDragOperationMove = 16;
		public const int NSDragOperationDelete = 32;
		public const uint NSDragOperationEvery = uint.MaxValue;
	}

	public static class NSDraggingDestinationForNSObjectCategory
	{
		public static UInt32 draggingEntered(this NSObject _instance, NSObject sender)
		{
			return _instance.Call("draggingEntered:", sender).To<UInt32>();
		}

		public static UInt32 draggingUpdated(this NSObject _instance, NSObject sender)
		{
			return _instance.Call("draggingUpdated:", sender).To<UInt32>();
		}

		public static void draggingExited(this NSObject _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("draggingExited:", sender);
		}

		public static bool prepareForDragOperation(this NSObject _instance, NSObject sender)
		{
			return _instance.Call("prepareForDragOperation:", sender).To<bool>();
		}

		public static bool performDragOperation(this NSObject _instance, NSObject sender)
		{
			return _instance.Call("performDragOperation:", sender).To<bool>();
		}

		public static void concludeDragOperation(this NSObject _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("concludeDragOperation:", sender);
		}

		public static void draggingEnded(this NSObject _instance, NSObject sender)
		{
			Unused.Value = _instance.Call("draggingEnded:", sender);
		}

		public static bool wantsPeriodicDraggingUpdates(this NSObject _instance)
		{
			return _instance.Call("wantsPeriodicDraggingUpdates").To<bool>();
		}
	}

	public static class NSDraggingSourceForNSObjectCategory
	{
		public static UInt32 draggingSourceOperationMaskForLocal(this NSObject _instance, bool flag)
		{
			return _instance.Call("draggingSourceOperationMaskForLocal:", flag).To<UInt32>();
		}

		public static NSArray namesOfPromisedFilesDroppedAtDestination(this NSObject _instance, NSURL dropDestination)
		{
			return _instance.Call("namesOfPromisedFilesDroppedAtDestination:", dropDestination).To<NSArray>();
		}

		public static void draggedImageBeganAt(this NSObject _instance, NSImage image, NSPoint screenPoint)
		{
			Unused.Value = _instance.Call("draggedImage:beganAt:", image, screenPoint);
		}

		public static void draggedImageEndedAtOperation(this NSObject _instance, NSImage image, NSPoint screenPoint, UInt32 operation)
		{
			Unused.Value = _instance.Call("draggedImage:endedAt:operation:", image, screenPoint, operation);
		}

		public static void draggedImageMovedTo(this NSObject _instance, NSImage image, NSPoint screenPoint)
		{
			Unused.Value = _instance.Call("draggedImage:movedTo:", image, screenPoint);
		}

		public static bool ignoreModifierKeysWhileDragging(this NSObject _instance)
		{
			return _instance.Call("ignoreModifierKeysWhileDragging").To<bool>();
		}

		public static void draggedImageEndedAtDeposited(this NSObject _instance, NSImage image, NSPoint screenPoint, bool flag)
		{
			Unused.Value = _instance.Call("draggedImage:endedAt:deposited:", image, screenPoint, flag);
		}
	}
}
