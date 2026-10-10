# Far Cry 4 + Bloons TD 6 Outpost Defense Mashup

This repo is the first playable prototype for a Far Cry 4 host-game mashup using Bloons-style tower defense inside claimed outposts.

## Overview
- Host game: Far Cry 4
- Companion game content: Bloons TD 6 tower logic, tower lineup, wave pacing, upgrades, and economy
- Goal: enter a claimed outpost, place towers, trigger a siege, survive waves, and hold the outpost
- Mode: Solo only

## Project status
This is an initial prototype scaffold. It is intended to be built and iterated locally before packaging for Melty.

## Structure
- `src/` gameplay and app logic
- `data/` JSON definitions for towers and waves
- `melty.json` Melty recipe metadata

## Local dev note
The production version is intended to run as a Far Cry 4-hosted mod layer, reading the player's installed Far Cry 4 folder path and launching from that install. The actual file injection and host-game API integration depend on the real installed version of Far Cry 4 and the chosen mod loader/engine route.

## First playable scope
- 1 outpost defense loop
- 4 tower types: Dart Monkey, Tack Shooter, Sniper Monkey, Bomb Shooter
- Manual siege trigger
- Enemy wave progression
- Cash and upgrade flow
- Win/lose conditions
