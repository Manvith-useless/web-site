# Cameleon: Dual Fate

Third-person action-adventure with stealth, co-op, and branching endings set across Earth Prime and Earth 554567. Play as Cameleon and Zero (Redemption) or Devil and Eclipse (Corruption), each with unique abilities, missions, and boss fights.

## Repository Structure
- docs/
  - GDD.md
  - MissionDesign.md
  - TechnicalArchitecture.md
- UnityProject/
  - Assets/
    - Scripts/ (gameplay code scaffolds)

## Quick Start (Unity)
1. Use Unity 2022.3 LTS or newer.
2. Create an empty HDRP project or add HDRP to an existing project.
3. Copy `UnityProject/Assets` into your Unity project `Assets` folder.
4. Open the sample scene (to be added) and press Play.

## Key Systems (Scaffolded)
- PlayerController, EnemyController
- EchoBladesController, ComboSystem, StealthSystem
- MoralitySystem, MissionSystem
- Abilities: ShapeShift, WeaponMastery, ConsumeAbility

## HDRP Setup
1. Install HDRP via Package Manager.
2. Use the HDRP Wizard to fix all project settings.
3. Create a Global Volume with exposure and ambient occlusion.
4. Set up a default HDRP camera and sky.

## Input System Setup
1. Install "Input System" package and enable it in Player Settings.
2. Restart the editor when prompted.
3. Use legacy axes temporarily (`Horizontal`, `Vertical`, mouse buttons) or create an Input Actions asset.

## Next
- Configure HDRP, Input System, and sample scene.
- Implement vertical slice: Awakening mission (stealth + combat tutorial).

# web-site