# Technical Architecture — Unreal Engine 5 (UE5.4+)

## Overview
- Languages: C++ for core gameplay; Blueprints for mission logic; GAS for abilities.
- Networking: 2-player online co-op; client-authoritative inputs with server reconciliation.
- Streaming: World Partition + HLODs; Nanite + Lumen for visuals.

## Modules
- GameplayCore (C++): character controllers, movement, combat, input mapping.
- AbilitySystems (C++/GAS): abilities for shape-shift, echo chain, weapon mastery, shadows.
- AIAndEncounters (C++/BT): behavior trees, EQS, suspicion/alert subsystem.
- Missions (BP/C++): mission controllers, objectives, triggers, checkpoint saves.
- Progression (C++): skill trees, economy, reputation system.
- UI (UMG): HUD, suspicion meter, dialogue prompts, objectives.

## Key Classes
- ACameleonCharacter, AZeroCharacter, ADevilCharacter, AEclipseCharacter
- UMeridanAwakeningComponent (scan profiles, manage disguises)
- UEchoBladeComponent (chain latch, pull, traversal, bleed stacks)
- UWeaponMasteryComponent (context buffs, copy buffer)
- UConsumptionComponent (energy reserve, corruption meter)
- UShadowFieldComponent (fog, binds, decoys)
- AMissionControllerBase, AMissionController_M01
- ASuspicionVolume, AAccessDoor, ADataTerminal, AExtractionZone

## GAS Abilities (Sample)
- UGA_ShapeShift_Scan, UGA_Disguise_Equip
- UGA_EchoChain_Pull, UGA_EchoBlade_Execute
- UGA_Zero_CopyBuffer, UGA_Zero_StanceSwap
- UGA_Devil_Consume, UGA_Devil_Detonate
- UGA_Eclipse_ShadowBind, UGA_Eclipse_ShadowClone

## Replication Strategy
- Combat hit confirmation server-side; cosmetic swings client-side with animation prediction.
- Suspicion/Alarm as server-authoritative; local prediction for UI smoothness.
- Disguise state replicated to relevant clients only (area-of-interest).

## Save/Load
- Slot-based checkpoints; mission state enum; inventory, disguises, and reputation persisted.

## Data Assets
- DT_Abilities, DT_EnemyArchetypes, DT_Disguises, DT_LevelRoutes, DT_Dialogue.

## Tools & Pipelines
- Control Rig for characters; IK Retargeter for cross-campaign moves.
- Niagara for Echo trails; MetaSounds for resonance FX.
- Automation: CI with Unreal Build Tool; nightly cook; functional tests for stealth and combat.

## Performance Targets
- 60 FPS performance mode (scalability groups); 30 FPS quality with RT.
- Budget: 3-4ms GPU for post; 5ms Niagara; 2ms Physics; 3ms AI.

## Risks & Mitigations
- Network desync in co-op: prioritize deterministic ability windows; add lag compensation.
- Complex AI perception: isolate scent/visual cones; tune EQS costs.