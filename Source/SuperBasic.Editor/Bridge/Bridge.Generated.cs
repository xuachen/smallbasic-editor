// <copyright file="Bridge.Generated.cs" company="2018 Omar Tawfik">
// Copyright (c) 2018 Omar Tawfik. All rights reserved. Licensed under the MIT License. See LICENSE file in the project root for license information.
// </copyright>

/// <summary>
/// This file is auto-generated by a build task. It shouldn't be edited by hand.
/// </summary>
namespace SuperBasic.Editor
{
    using System.Threading.Tasks;
    using Microsoft.JSInterop;
    using SuperBasic.Utilities.Bridge;

    internal static class Bridge
    {
        public static class Process
        {
            public static async Task OpenExternalLink(string url)
            {
                await JSRuntime.Current.InvokeAsync<bool>("Bridge.Process.OpenExternalLink", url).ConfigureAwait(false);
            }
        }

        public static class File
        {
            public static Task<FileBridgeModels.Result> AppendContents(FileBridgeModels.PathAndContentsArgs args)
            {
                return JSRuntime.Current.InvokeAsync<FileBridgeModels.Result>("Bridge.File.AppendContents", args);
            }

            public static Task<FileBridgeModels.Result> CopyFile(FileBridgeModels.SourceAndDestinationArgs args)
            {
                return JSRuntime.Current.InvokeAsync<FileBridgeModels.Result>("Bridge.File.CopyFile", args);
            }

            public static Task<FileBridgeModels.Result> CreateDirectory(string directoryPath)
            {
                return JSRuntime.Current.InvokeAsync<FileBridgeModels.Result>("Bridge.File.CreateDirectory", directoryPath);
            }

            public static Task<FileBridgeModels.Result> DeleteDirectory(string directoryPath)
            {
                return JSRuntime.Current.InvokeAsync<FileBridgeModels.Result>("Bridge.File.DeleteDirectory", directoryPath);
            }

            public static Task<FileBridgeModels.Result> DeleteFile(string filePath)
            {
                return JSRuntime.Current.InvokeAsync<FileBridgeModels.Result>("Bridge.File.DeleteFile", filePath);
            }

            public static Task<FileBridgeModels.Result<string[]>> GetDirectories(string directoryPath)
            {
                return JSRuntime.Current.InvokeAsync<FileBridgeModels.Result<string[]>>("Bridge.File.GetDirectories", directoryPath);
            }

            public static Task<FileBridgeModels.Result<string[]>> GetFiles(string directoryPath)
            {
                return JSRuntime.Current.InvokeAsync<FileBridgeModels.Result<string[]>>("Bridge.File.GetFiles", directoryPath);
            }

            public static Task<FileBridgeModels.Result<string>> GetTemporaryFilePath()
            {
                return JSRuntime.Current.InvokeAsync<FileBridgeModels.Result<string>>("Bridge.File.GetTemporaryFilePath");
            }

            public static Task<FileBridgeModels.Result> InsertLine(FileBridgeModels.PathAndLineAndContentsArgs args)
            {
                return JSRuntime.Current.InvokeAsync<FileBridgeModels.Result>("Bridge.File.InsertLine", args);
            }

            public static Task<FileBridgeModels.Result<string>> ReadContents(string filePath)
            {
                return JSRuntime.Current.InvokeAsync<FileBridgeModels.Result<string>>("Bridge.File.ReadContents", filePath);
            }

            public static Task<FileBridgeModels.Result<string>> ReadLine(FileBridgeModels.PathAndLineArgs args)
            {
                return JSRuntime.Current.InvokeAsync<FileBridgeModels.Result<string>>("Bridge.File.ReadLine", args);
            }

            public static Task<FileBridgeModels.Result> WriteContents(FileBridgeModels.PathAndContentsArgs args)
            {
                return JSRuntime.Current.InvokeAsync<FileBridgeModels.Result>("Bridge.File.WriteContents", args);
            }

            public static Task<FileBridgeModels.Result> WriteLine(FileBridgeModels.PathAndLineAndContentsArgs args)
            {
                return JSRuntime.Current.InvokeAsync<FileBridgeModels.Result>("Bridge.File.WriteLine", args);
            }
        }

        public static class ImageList
        {
            public static Task<ImageListBridgeModels.ImageData> LoadImage(string fileNameOrUrl)
            {
                return JSRuntime.Current.InvokeAsync<ImageListBridgeModels.ImageData>("Bridge.ImageList.LoadImage", fileNameOrUrl);
            }
        }
    }
}
