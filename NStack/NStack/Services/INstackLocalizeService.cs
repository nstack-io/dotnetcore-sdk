﻿using NStack.SDK.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NStack.SDK.Services
{
    public interface INStackLocalizeService
    {
        /// <summary>
        /// Get a list of available languages on the given <paramref name="platform"/>.
        /// </summary>
        /// <param name="platform">The platform to fetch available languages from.</param>
        Task<DataWrapper<List<ResourceData>>> GetLanguages(NStackPlatform platform);

        /// <summary>
        /// Fetch the default translation.
        /// </summary>
        /// <typeparam name="TSection">The type of the translations.</typeparam>
        /// <param name="platform">The platform to fetch the resource for.</param>
        Task<DataMetaWrapper<TSection>> GetDefaultResource<TSection>(NStackPlatform platform) where TSection : ResourceItem;

        /// <summary>
        /// Fetch the default translation.
        /// </summary>
        /// <param name="platform">The platform to fetch the resource for.</param>
        Task<DataMetaWrapper<ResourceItem>> GetDefaultResource(NStackPlatform platform);

        /// <summary>
        /// Fetch translations for the given <paramref name="id"/>.
        /// </summary>
        /// <typeparam name="TSection">The type of the translations.</typeparam>
        /// <param name="id">The id of the translation to fetch.</param>
        Task<DataMetaWrapper<TSection>> GetResource<TSection>(int id) where TSection : ResourceItem;

        /// <summary>
        /// Fetch translations for the given <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The id of the translation to fetch.</param>
        Task<DataMetaWrapper<ResourceItem>> GetResource(int id);

        /// <summary>
        /// Fetch translations for the given <paramref name="locale"/>.
        /// </summary>
        /// <typeparam name="TSection">The type of the translations.</typeparam>
        /// <param name="locale">The locale to fetch.</param>
        /// <param name="platform">The platform to fetch the resource for.</param>
        /// <exception cref="ArgumentNullException"></exception>
        Task<DataMetaWrapper<TSection>> GetResource<TSection>(string locale, NStackPlatform platform) where TSection : ResourceItem;

        /// <summary>
        /// Fetch translations for the given <paramref name="locale"/>.
        /// </summary>
        /// <param name="id">The locale to fetch.</param>
        /// <param name="platform">The platform to fetch the resource for.</param>
        /// <exception cref="ArgumentNullException"></exception>
        Task<DataMetaWrapper<ResourceItem>> GetResource(string locale, NStackPlatform platform);
    }
}
