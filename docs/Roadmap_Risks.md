# Production Roadmap and Risks

## Milestones
- M0: Foundations (2 weeks) — repo, CI, input, camera, character locomotion.
- M1: Combat/Stealth MVP (3 weeks) — stances, parry, LOS stealth, disguise meter.
- M2: Mission 1 Graybox (3 weeks) — space, patrol AI, interrogation, hazards.
- M3: Co-Op MVP (1 week) — join-in-progress, revive, synced takedown.
- M4: Vertical Slice Polish (2 weeks) — art pass, audio, accessibility, perf.

## Risks & Mitigations
- Scope Creep: lock ending count; prioritize Redemption campaign for slice.
- Networking Complexity: constrain to P2P host; sync only critical gameplay.
- Animation Fidelity: prioritize readable timings; use Motion Warping and Montage sections.
- AI Pathing in Crowds: baked splines + dynamic avoidance; cap concurrent agents.
- Morality Readability: surface consequences via VO and world state, not bars.

## Tools & Pipelines
- Version Control: Git + LFS; trunk-based with feature branches.
- CI: nightly cook and automated functional tests on mission flow.
- Asset Naming/Dirs: standardized UE naming, modular kits.

