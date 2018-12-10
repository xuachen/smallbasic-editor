﻿// <copyright file="MonacoEditor.cs" company="2018 Omar Tawfik">
// Copyright (c) 2018 Omar Tawfik. All rights reserved. Licensed under the MIT License. See LICENSE file in the project root for license information.
// </copyright>

namespace SuperBasic.Editor.Components.Toolbox
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using SuperBasic.Editor.Components.Layout;
    using SuperBasic.Editor.Interop;
    using SuperBasic.Editor.Store;

    public sealed class MonacoEditor : SuperBasicComponent, IDisposable
    {
        private ElementRef editorElement = default;

        [Parameter]
        private bool IsReadOnly { get; set; }

        public static void Inject(TreeComposer composer, bool isReadOnly)
        {
            composer.Inject<MonacoEditor>(new Dictionary<string, object>
            {
                { nameof(MonacoEditor.IsReadOnly), isReadOnly },
            });
        }

        public void Dispose()
        {
            JSInterop.Monaco.Dispose().ConfigureAwait(false);
        }

        protected override Task OnAfterRenderAsync()
        {
            return JSInterop.Monaco.Initialize(this.editorElement, CompilationStore.Compilation.Text, this.IsReadOnly);
        }

        protected override void ComposeTree(TreeComposer composer)
        {
            composer.Element("editor-container", body: () =>
            {
                composer.Element("editor", capture: element => this.editorElement = element);
            });
        }
    }
}