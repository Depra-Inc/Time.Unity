using System.Runtime.CompilerServices;

namespace Depra.Time
{
	public sealed class UnityFrameClock : IFrameClock
	{
		float IFrameClock.FrameTime
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => UnityEngine.Time.deltaTime;
		}

		float IFrameClock.FixedFrameTime
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => UnityEngine.Time.fixedDeltaTime;
		}
	}
}