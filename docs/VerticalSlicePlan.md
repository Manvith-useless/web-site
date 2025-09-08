# Vertical Slice Plan — Cameleon: Dual Fate

## Scope
- Scene: SCN_Awakening (Rooftop → Offices → Vault → Arena → Escape)
- Playables: Cameleon (primary), Zero (assist/demo room)
- Core loops: movement, stealth (disguise + suspicion), Echo Blades light/heavy + 3-step combo, mini-boss
- Systems: MissionSystem, MoralitySystem (single choice), basic EnemyController patrol/chase

## Deliverables
- Functional scene with lighting and basic HDRP post-processing
- 1 enemy archetype (Guard) + 1 mini-boss (Enforcer)
- Echo Blades animations placeholders (anim events hook)
- Disguise pickup + suspicion gameplay gates
- Choice prompt (spare/kill witness) → morality delta → end card

## Milestones
1. Greybox layout and nav (Day 1)
2. Movement + camera + stealth loop (Day 2)
3. Combat loop + mini-boss (Day 3)
4. Mission flow + choice + UI polish (Day 4)
5. Lighting pass + performance + builds (Day 5)

## Risks & Mitigations
- Shape-shift recognition: use simple trigger-based disguise pickups initially
- Combat feel: implement hitstop and camera shake stubs; tune later
- Performance in HDRP: keep materials simple; bake lighting where possible