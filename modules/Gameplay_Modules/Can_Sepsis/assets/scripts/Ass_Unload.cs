function Module_Can_Sepsis::Ass_Unload(%this)
{

if (isObject(%this.Ass_Image_Floor))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Floor.getAssetId());

}

/**************************************************************************************************************/

if (isObject(%this.Ass_Image_Ladder))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Ladder.getAssetId());

}

/**************************************************************************************************************/

if (isObject(%this.Ass_Image_Potion))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Potion.getAssetId());

}

/**************************************************************************************************************/

if (isObject(%this.Ass_Image_Room))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Room.getAssetId());

}

/**************************************************************************************************************/

if (isObject(%this.Ass_Image_Fog))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Fog.getAssetId());

}

/**************************************************************************************************************/

if (isObject(%this.Ass_Image_Child_F))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Child_F.getAssetId());

}

if (isObject(%this.Ass_Image_Child_F_Attack))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Child_F_Attack.getAssetId());

}

if (isObject(%this.Ass_Image_Child_F_Cast))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Child_F_Cast.getAssetId());

}

/**************************************************************************************************************/

if (isObject(%this.Ass_Image_Male_0))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Male_0.getAssetId());

}

if (isObject(%this.Ass_Image_Male_0_Attack))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Male_0_Attack.getAssetId());

}

if (isObject(%this.Ass_Image_Male_0_Cast))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Male_0_Cast.getAssetId());

}

/**************************************************************************************************************/

if (isObject(%this.Ass_Image_Zombie))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Zombie.getAssetId());

}

if (isObject(%this.Ass_Image_Zombie_Attack))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Zombie_Attack.getAssetId());

}

if (isObject(%this.Ass_Image_Zombie_Cast))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Zombie_Cast.getAssetId());

}

/**************************************************************************************************************/

if (isObject(%this.Ass_Image_Sara))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Sara.getAssetId());

}

if (isObject(%this.Ass_Image_Sara_Attack))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Sara_Attack.getAssetId());

}

if (isObject(%this.Ass_Image_Sara_Cast))
{

AssetDatabase.releaseAsset(%this.Ass_Image_Sara_Cast.getAssetId());

}

/**************************************************************************************************************/

}
