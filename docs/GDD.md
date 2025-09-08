# Cameleon: Dual Fate — Game Design Document (GDD)

## 1. Vision Statement
Create a cinematic third-person action-adventure with stealth, expressive melee-combat, and co-op, set across two parallel Earths. Players embody morally complex protagonists (Cameleon, Zero) or antagonists (Devil, Eclipse) whose choices shape branching narratives and multiple endings.

## 2. Pillars
1) Identity and Deception: shape-shifting, social stealth, moral ambiguity.
2) Cinematic Combat: Echo Blades flow, brutality, readable enemy telegraphs, high responsiveness.
3) Parallel-World Intrigue: Earth Prime vs Earth 554567, mirroring locales with mechanical twists.
4) Co-op Synergy: duo tactics, combo abilities, complementary roles.
5) Player Agency: consequential choices, multiple endings, character-specific arcs.

## 3. Platforms & Target Quality
- PC and next-gen consoles.
- Visual target: GTA V+ fidelity with UE5 features (Nanite, Lumen, Niagara, MetaSounds).
- 60 FPS performance mode; 30 FPS quality mode with RT features.

## 4. Player Characters
- Cameleon: illegal Meridan awakener; shape-shifts into any scanned human. Weapon: Echo Blades (chained dual blades + serrated combat knife). Role: stealth/infiltration + stance-based aggression.
- Zero: weapon savant from Earth 554567; instantly masters any weapon. Role: adaptive DPS/support, stance swaps for ranged/melee.
- Devil: Cameleon’s corrupted friend; pact with Greed; consumes matter to raw energy. Role: sustain-tank, resource conversion mechanics.
- Eclipse: Zero’s master; manipulates shadows/illusions. Role: controller/assassin, battlefield manipulation.

## 5. Game Structure
- Campaigns: Redemption (Cameleon + Zero) and Corruption (Devil + Eclipse).
- Chapters: 10–12 missions each campaign; shared set-pieces diverge in objectives and POV.
- Hub: Safehouse between missions (loadout, upgrades, dialogue, evidence board).

## 6. Moment-to-Moment Gameplay
- Stealth: shape-shift disguises, line-of-sight cones, suspicion meter, social spaces, silent takedowns, environmental hides, distraction gadgets.
- Combat: third-person melee with lock-on, light/heavy chains, launcher, gap-closers, parries, perfect dodges, executions. Echo Blades rope-pull, blade-return, bleeding stacks; Knife backstabs, serration DOT.
- Co-op: tag-team finishers, combo states (Juggle, Stagger, Exposed), role synergies (Disguise + Decoy, Shadow Bind + Blade Pull). Drop-in/out online; optional AI companion.
- Traversal: parkour vaulting, mantle, grapples (blade-chain), zip-lines, slide, wall-run (selected surfaces), stealth routes.

## 7. Core Systems
7.1 Shape-Shifting
- Scan NPCs (close-range AR capture). Store up to N profiles with risk rating.
- Disguise breaks with direct witness of a crime, biometric scanners, or Meridan-aware enemies.
- Social keys: uniforms unlock zones, dialogue options, access levels.

7.2 Echo Blades Combat
- Stances: Stealth, Balanced, Brutal. Stance shifts alter move list, speed, damage, and special.
- Chain Mechanics: latch to enemies/anchors, yank/pull, area sweep, traversal hook.
- Resource: Resonance Meter (builds with perfect timing) powers blade echoes (after-image slashes) and executions.

7.3 Zero’s Weapon Mastery
- Contextual weapon proficiency buffs upon pickup; unlocks advanced moves quickly.
- Copy Buffer: briefly mimics enemy signature attacks after perfect parry.

7.4 Devil’s Consumption
- Consume world objects/enemies to convert into Energy Reserve; spend for shields, beam bursts, or area detonations.
- Corruption meter grows with consumption; triggers narrative/ending flags.

7.5 Eclipse’s Shadows
- Shadow fields reduce visibility, create decoys, anchor teleport points, bind targets.

## 8. Progression & Economy
- Skill trees per character; cross-campaign unlock echoes (cosmetics, moves, narrative lore).
- Gear: craftable gadgets (drones, scramblers), Echo Blade mods, weapon attachments.
- Reputation: factions across both Earths respond to actions; unlocks safehouses, black markets, intel.

## 9. AI & Encounter Design
- Enemy archetypes: Patrol, Enforcer, Meridan Sentinel, Analyst (detects disguises), Heavy, Elite, Shadowbound.
- States: idle, investigate, alert, pursuit, lost, escalate. Social AI reacts to uniforms and suspicious behaviors.
- Boss layers: multi-phase health, armor, mechanics, and arena hazards.

## 10. Key Missions (High-Level)
- Cameleon vs Devil: collapsing city with unstable Meridans; shifting cover, explosive hazards, crowd panic.
- Zero vs Eclipse: illusion chamber; shifting geometry, shadow clones, puzzle-combat fusion.

## 11. Narrative Themes & Structure
- Themes: identity, justice, betrayal, redemption. Branches driven by critical decisions, disguise ethics, collateral damage, and ally trust.
- Endings: Redemption (self-sacrifice or reform), Ambiguous (break chains), Corruption (control via fear/consumption).

## 12. Co-op Design
- Story-cohesive dual roles; shared objectives with split-tasks (simultaneous hacks, synced takedowns).
- Assist-res mechanics; shared resonance boosts when coordinated.

## 13. Accessibility & UX Targets
- Remap controls, subtitles/SDH, colorblind palettes, QTE toggles, aim assist sliders, difficulty modifiers, stealth assists (cone highlights), combat timing windows.

## 14. Monetization & Post-Launch
- Premium game. Cosmetic DLC, challenge arenas, narrative episodes. No pay-to-win.

## 15. Technical Notes (UE5)
- UE5.4+, C++ + Blueprints; GAS for abilities; Subsystems for progression/AI. Replication ready for 2-player online.
- Streaming: World Partition, HLODs. Physics: Chaos. VFX: Niagara. Audio: MetaSounds.

## 16. Risks
- Scope: dual campaigns and co-op complexity. Mitigate via modular mission design and vertical slice first.
- Stealth + action tuning: extensive playtesting with metrics.

## 17. Vertical Slice (Target)
- Single district map with social stealth, one infiltration mission, mini-boss, and a short illusion arena.

