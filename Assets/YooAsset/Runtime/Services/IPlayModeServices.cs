﻿
namespace YooAsset
{
	internal interface IPlayModeServices
	{
		/// <summary>
		/// 激活的清单
		/// </summary>
		PatchManifest ActiveManifest { set; get; }

		/// <summary>
		/// 是否为内置资源文件
		/// </summary>
		bool IsBuildinPatchBundle(PatchBundle patchBundle);

		/// <summary>
		/// 向网络端请求最新的资源版本
		/// </summary>
		UpdatePackageVersionOperation UpdatePackageVersionAsync(bool appendTimeTicks, int timeout);

		/// <summary>
		/// 向网络端请求并更新补丁清单
		/// </summary>
		UpdatePackageManifestOperation UpdatePackageManifestAsync(string packageVersion, int timeout);

		/// <summary>
		/// 检查包裹内容的完整性
		/// </summary>
		CheckContentsIntegrityOperation CheckContentsIntegrityAsync();

		// 下载相关
		PatchDownloaderOperation CreatePatchDownloaderByAll(int downloadingMaxNumber, int failedTryAgain, int timeout);
		PatchDownloaderOperation CreatePatchDownloaderByTags(string[] tags, int downloadingMaxNumber, int failedTryAgain, int timeout);
		PatchDownloaderOperation CreatePatchDownloaderByPaths(AssetInfo[] assetInfos, int downloadingMaxNumber, int failedTryAgain, int timeout);

		// 解压相关
		PatchUnpackerOperation CreatePatchUnpackerByAll(int upackingMaxNumber, int failedTryAgain, int timeout);
		PatchUnpackerOperation CreatePatchUnpackerByTags(string[] tags, int upackingMaxNumber, int failedTryAgain, int timeout);
	}
}