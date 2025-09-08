# Mission 01: False Faces (Blockout + Scripting Spec)

## Overview
- Campaign: Redemption (Cameleon + Zero)
- Location: Earth Prime — Meridan Compliance Bureau (MCB) District HQ
- Type: Infiltration -> Reveal -> Extraction
- Objective: Infiltrate HQ, access Meridan instability logs, exfiltrate with evidence without triggering full lockdown.

## Narrative Beat
Cameleon learns that Devil brokered Meridan smuggling deals inside the MCB. A disguised entry turns into a moral test: protect civilians while exposing corruption, or stay covert and let casualties rise.

## Win / Fail Conditions
- Win: Upload signed data packet at roof relay OR exfiltrate with physical drive via loading dock.
- Fail: Alarm level reaches MAX (lockdown), or both players incapacitated.

## Stealth & Social Systems
- Disguises Required: Janitor, Analyst, Sentinel. Each grants access to color-coded zones.
- Suspicion Sources: running in restricted zones, weapons drawn, failed dialogue checks, camera detection, Analyst NPC proximity.
- Tools: noise darts, EMP puck, fake keycards, echo-chain latch to vents.

## Level Blockout (Greybox)
- Exterior Street: cover objects, patrols, civilians; side alley to maintenance.
- Lobby: metal detectors, camera arcs, reception, vertical sightlines to mezzanine.
- Offices (Open Plan): cubicles, glass rooms, line-of-sight puzzles, Analyst patrol.
- Server Core: rotating lasers, cooling fog, catwalks; vertical traversal using chain.
- Roof Relay: satellite dish, helipad; extraction zones.

## Encounters
1) Entry: pass detectors using Janitor disguise or chain to vent.
2) Office Sweep: acquire Analyst disguise via social stealth; optional dialogue mini-check.
3) Server Core: timed laser grid; perfect dodge windows; stealth takedowns.
4) Reveal: Devil remote-trigger instability; environmental hazards (Meridan surges) alter patrol routes.
5) Extraction: choice of roof (loud) or loading dock (quiet). Co-op sync action required.

## Co-op Design
- Sync Interactions: dual hack (3s window), synchronized takedown, decoy + disguise bait.
- Failure Recovery: partner revive; temporary decoy via Zero’s weapon mimic.

## Scripting Spec (Unreal Engine 5)
- Framework: GAS Abilities + Blueprint scripting for mission logic; Subsystem for suspicion/alert.

### Mission Flow State Machine
- States: Init -> Infiltration -> DataAcquired -> InstabilityEvent -> Extraction -> Complete/Fail.
- Persistence: checkpoint at Infiltration start and post-DataAcquired.

### Key Blueprint Actors
- BP_MissionController_M01
  - Variables: AlarmLevel (0-100), DisguiseTier (None/Low/Mid/High), ObjectiveState (enum), EvidenceAcquired (bool)
  - Events: OnAlarmChanged, OnEvidenceAcquired, OnInstabilityTriggered, OnExtractionSelected
- BP_SuspicionVolume
- BP_AccessDoor (AccessLevel int, OpensOnDisguiseTier >= requirement)
- BP_DataTerminal (RequiresAnalyst or HackDifficulty)
- BP_ExtractionZone (Roof/Dock)

### GAS Abilities (Examples)
- GA_ShapeShift_Scan: short-range scan, stores profile, risk rating.
- GA_Disguise_Equip: consumes scanned profile; timer-based suspicion decay on good behavior.
- GA_EchoChain_Pull: latch points; yank objects; traversal hook.
- GA_Zero_CopyBuffer: store enemy move; single-use counter.

### UI / HUD
- Suspicion Meter (segment-based), Alarm Level, Objective Prompts, Disguise Badge.

### Triggers & Conditions (Pseudo)
On BeginPlay:
  Set State = Init
  AlarmLevel = 0
  DisguiseTier = None
  Objective: Infiltrate HQ

On PlayerEnter Lobby & Not Disguised:
  Increment AlarmLevel += 15

On DataTerminal Download Complete:
  EvidenceAcquired = true
  Set State = DataAcquired
  Objective: Reach Extraction (choose route)

On InstabilityEvent Fired (scripted mid-mission):
  Enable HazardVolumes
  Reroute PatrolSplines

On ExtractionZone Overlap & EvidenceAcquired:
  If Roof -> spawn HelipadWave, call evac after 60s
  If Dock -> stealth timer 20s; if unseen, complete

### Metrics & Telemetry
- Time to first disguise, detection count, perfect parry rate, stealth route chosen, alarm spikes.

### Difficulty Modifiers
- Casual: larger stealth windows, slower alarms, fewer Analysts.
- Standard: baseline.
- Hardcore: instant fails on camera + Analyst combo; tighter timing.

## Deliverables for Vertical Slice
- Greybox level in UE5 with World Partition
- Functional disguises, suspicion, and alarm loop
- Working Echo Chain traversal anchors
- Two extraction routes with win logic