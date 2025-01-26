// SPDX-License-Identifier: Apache-2.0
// © 2024-2025 Nikolay Melnikov <n.melnikov@depra.org>

using System.Runtime.CompilerServices;

namespace Depra.Time
{
	public sealed class UnityClock : IClock
	{
		float IClock.ElapsedTime 
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => UnityEngine.Time.time;
		}
	}
}