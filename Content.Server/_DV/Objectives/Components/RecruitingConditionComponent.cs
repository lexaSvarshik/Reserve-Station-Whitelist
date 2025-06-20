// SPDX-FileCopyrightText: 2025 ReserveBot <211949879+ReserveBot@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Svarshik <96281939+lexaSvarshik@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Server.Objectives.Systems;
using Content.Shared._DV.Recruiter;

namespace Content.Server.Objectives.Components;

/// <summary>
/// Objective condition that requires the recruiter's pen to be used by a number of people to sign paper.
/// Requires <see cref="NumberObjectiveComponent"/> to function.
/// </summary>
[RegisterComponent, Access(typeof(RecruitingConditionSystem), typeof(SharedRecruiterPenSystem))]
public sealed partial class RecruitingConditionComponent : Component
{
    [DataField]
    public int Recruited;
}
