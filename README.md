![My cabbages!!!](https://i.imgur.com/KmLF0Y7.png)

Not being able to get enough seeds to expand my farms pushed me to make a simple content mod which allows to choose between getting food or seeds.

The mod is balanced to be as similar as possible as vanilla:

- wild grain/legume crops yield enough to convert at least some to seed
- wild vegetable crops include flowering stages so vegetable seeds are harvestable in the wild
- when converting half of the grain/legume harvest to seed, the food/seed yield will be identical to vanilla for the same number of crops
- when letting half of the vegetable crops flower, the food/seed yield will be identical to vanilla for the same number of crops as long as it's an even number

### Overview

This mod changes the crops' growth stages and the amounts of seeds and food dropped on harvest, and adds a way to replant grains and legumes.

#### Vegetables

- All vegetables get an additional growth stage (and a slightly longer growth time to compensate)
- Vegetables have only a small chance to drop a seed when they're in the mature growth stage (second to last stage)
- At the last stage vegetables will be flowering and harvesting them will yield double the seeds that the crop would yield in vanilla, plus some plant debris
- When mature vegetables drop double the food amount they drop in vanilla

#### Legumes and grains

- All legumes and grains don't drop seeds
- When harvested in the mature growth stage the crops will yield a double amount of grains/legumes to compensate, plus some plant debris for leafy plants or dry grass for non-leafy plants (most grains)
- When harvested in the second to last growth stage the crops will yield the usual amount of grains/legumes
- Additionally, there's a small chance for crops to drop a smaller amount of grains/legumes when harvested in the third to last growth stage
- It will be possible to craft a seed packet using about half of the crop's harvest

#### Exceptions

- Pumpkins work differently so I left them alone
- I didn't even want to think about how to deal with pineapples
- Licorice makes sense as it is so I didn't change it

### Features

- new seed recipes for all the grains and legumes
- cool new models for the flowering vegetables
- more plant debris for your composting needs!
- let some of your vegetables flower or you might run out of seeds
- expand your farms easily by starving yourself!
- bees and butterflies will feed on the vegetables only when they're flowering
- easily change the mod to your liking simply editing the json patches

### Special thanks

- @Trini for the awesome title image
- @TwoF for the russian translation
- @Pawelot00 for the polish translation
- @Spaturno for the amazing new flowering models (especially the cabbage)

### Vanilla-modded comparison

#### Cabbages

| General information | | |
|:---|:---:|:---:|
| | **Vanilla** | **Realistic farming** |
| Total growth stages | 12 | 13 |
| Mature stage | 12 | 12 |
| Flowering stage | - | 13 |
| Maturation time at ~100% growth speed | 1.5 months | 1.6 months |
| Seeds craftable with | - | - |

| Yields on harvest |||||
|:---|:---:|:---:|:---:|:---:|
| **Growth stage** | **Seed** | | **Other** | |
| | **Vanilla** | **Realistic farming** | **Vanilla** | **Realistic farming** |
| 11 (almost mature) | almost always 1 | 0 | often 1 cabbage | often 1 cabbage |
| 12 (mature) | at least 1 and rarely 2 | rarely 1 | 2 cabbages | 4 cabbages |
| 13 (flowering) | - | at least 2 and rarely 3 | - | 2 rot |

#### Rice

| General information | | |
|:---|:---:|:---:|
| Growth stages | 10 | 10 |
| Mature stage | 10 | 10 |
| Flowering stage | - | - |
| Maturation time at ~100% growth speed | 2.25 months | 2.25 months |
| Seeds craftable with | - | 11 rice |

| Yields on harvest |||||
|:---|:---:|:---:|:---:|:---:|
| **Growth stage** | **Seed** | | **Other** | |
| | **Vanilla** | **Realistic farming** | **Vanilla** | **Realistic farming** |
| 11 (almost mature) | 0 | 0 | 0 rice | 6-8 rice |
| 12 (mature) | at least 1 and rarely 2 | 0 | 6-8 rice | 12-16 rice |

### Compatibility

- I didn't test it with any other farming mods so let me know
- Probably compatible with [XSkills](https://mods.vintagestory.at/show/mod/247) but additional testing is required
- Compatible with [Herbarium](https://mods.vintagestory.at/herbarium), [Wildcraft: Herbs and Spices](https://mods.vintagestory.at/show/mod/10655), [Wildcraft: Fruits and Nuts](https://mods.vintagestory.at/show/mod/8515) and [Wildcraft: Trees and Shrubs](https://mods.vintagestory.at/show/mod/9909) (no errors while testing in a world with all those mods alongside Realistic Farming, and harvesting/cultivating the wildcraft plants seems to be working fine)

### Roadmap

- ~~possible rebalancing so that crops yield also 2x the vanilla food amount~~ added in v1.0.2
- add wilted vegetables that can't be eaten but can be used to feed animals or to make rot (like dry fruit mash) and get dropped in place of plant debris when the flowering plant is harvested
- add a seeding stage after the flowering stage
- ~~make flowering cassava as big as the mature plant~~ added in 1.0.6
- ~~make flowering cabbage as big as the mature plants~~ added in 1.0.6
- ~~add the "break to harvest" tooltip on the second to last growth stage for vegetables~~ added in v1.0.2
- translations
- ~~add a chance to spawn flowering vegetables at worldgen~~ added in v1.0.3

### Known bugs

1. ~~cassava doesn't drop seeds when flowering~~ fixed in 1.0.5
2. ~~vegetables flowering textures are floating a bit over the ground~~ fixed with proper models in 1.0.6

### Changelog

**v.1.0.6**

- Updated drops to match 1.22 vanilla decreased yields
- Added proper models for flowering stages. No more ugly 2d sprites!
- Added dry grass drops when harvesting mature grains
- Replaced rot drops with plant debris
- Added plant debris drops for leafy grains and legumes
- Added a chance for mature carrots to spawn at worldgen, since they never do in vanilla
- Added a seedling label for most crops
- Implemented flowering mechanic for fennel

**v.1.0.5**

- Fixed a bug that caused cassava to not drop seeds in the flowering stages
- Fixed a bug that caused peanuts to drop more in the second-to-last growth stage, and less in the last growth stage
- Added a very small chance for root vegetables to drop when harvested in their flowering stage (slightly higher for onions)
- Tested and updated for game version 1.20.x

**v.1.0.4**

- added russian translation (many thanks to @TwoF)
- fixed dead crops not dropping seeds

**v.1.0.3**

- added spawning of flowering vegetables at worldgen
- fixed a minor bug on carrots

**v.1.0.2**

- added "sprouting" label for first growth stage
- added "maturing" label for almost mature growth stage
- improved amaranth and cassava labels
- added interaction tooltips on maturing, mature and flowering stages
- rebalanced drops for vegetable crops (now equivalent to vanilla)
- minor fix for flowering cabbages in v1.20.0-pre*

**v.1.0.1**

- increased wild crops drop rates for both grains and vegetables
- added sprouting labels for first vegetables growth stages because I felt like it
- fixed almost mature amaranth drop rate