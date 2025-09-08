# Engine Choice and Prototype Plan

## Engine Choice: Unreal Engine 5 (5.4+)
- Rationale: state-of-the-art third-person template, Nanite/Lumen for fidelity, strong animation tools, Chaos physics, and replication features for co-op.
- Tooling: GAS (Gameplay Ability System) for abilities, Enhanced Input, State Trees for AI, Motion Warping for melee.

## Prototype Vertical Slice (8–10 weeks)
Week 1–2: Project setup, source control, core character controller, camera, lock-on.
Week 3–4: Echo Blades baseline (light/heavy, parry, stance swap), stealth MVP (LOS, luminance, disguise meter).
Week 5–6: Mission 1 graybox, crowd sim, patrol AI, interrogation interaction, Meridan hazards.
Week 7: Co-op drop-in, revive loop, synchronized takedown.
Week 8: Boss graybox (mini), UI/UX polish, performance pass.
Optional Week 9–10: Photomode, accessibility, cinematic passes.

## Technical Notes
- Networking: GAS abilities with Prediction Keys; minimal replication on cosmetic FX; host migration v2.
- Data: DataAssets for weapons/stances; Curves for stamina/Meridan; IK for Echo chain endpoints.
- Build Targets: Win64 + Linux; PS5/XSX as stretch after slice.

## Team Seat Map (Prototype)
- Engineering: 2 gameplay, 1 AI/networking, 1 tools.
- Design: 1 systems, 1 level (graybox), 1 narrative.
- Art: 1 character, 1 environment (modular), 1 tech artist.
- Audio: 1 sound designer (contract), 1 composer (contract).

