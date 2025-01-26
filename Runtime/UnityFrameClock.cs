// SPDX-License-Identifier: Apache-2.0
// © 2024-2025 Nikolay Melnikov <n.melnikov@depra.org>

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