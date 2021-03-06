﻿using LibVLCSharp.Shared;
using RaceControl.Common.Interfaces;

namespace RaceControl.Vlc
{
    public class VlcMediaRenderer : IMediaRenderer
    {
        private readonly RendererItem _rendererItem;

        public VlcMediaRenderer(RendererItem rendererItem)
        {
            _rendererItem = rendererItem;
        }

        public string Name => _rendererItem.Name;

        public object Renderer => _rendererItem;
    }
}