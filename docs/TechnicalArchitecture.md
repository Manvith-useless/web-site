# Technical Architecture — Cameleon: Dual Fate

## Systems Overview
- Input: Unity Input System (action maps: Player, UI, CoOp)
- Character: `PlayerController` using `CharacterController`; state machine (Locomotion, Combat, Stealth)
- Combat: `EchoBladesController`, `ComboSystem`, hitstop, stagger, invulnerability windows
- Stealth: `StealthSystem` with light/sight checks, suspicion, takedowns
- Abilities: `ShapeShift`, `WeaponMastery`, `ConsumeAbility`
- AI: `EnemyController` with NavMesh and simple behavior states
- Missions: `MissionSystem` with objective graph and triggers
- Morality: `MoralitySystem` tracking thresholds and broadcasting events
- Networking (co-op): abstraction layer ready for Netcode for GameObjects/Photon
- Persistence: save profiles, mission progression, reputation tracks

## Data & Events
- ScriptableObjects for weapons, enemies, combos, and mission definitions
- C# events/UnityEvents for damage, suspicion, morality deltas, objective updates

## Scene Layout (Vertical Slice)
- `SCN_Awakening` with zones: Rooftop → Offices → Vault → Arena → Escape
- Global systems in a bootstrap scene loaded additive

## Packages
- HDRP, Input System, Cinemachine, TextMeshPro, optionally Netcode or Photon

## Performance Goals
- 60 FPS target on mid-tier PC; pooled VFX; culling and LODs for heavy scenes

## Risk Areas
- Shape-shift UX and AI reaction correctness
- Complex boss arenas with heavy VFX under HDRP
- Co-op desync and rollback edge cases