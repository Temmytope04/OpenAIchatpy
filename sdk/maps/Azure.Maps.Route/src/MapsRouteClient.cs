// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.GeoJson;
using Azure.Core.Pipeline;
using Azure.Maps.Route.Models;

namespace Azure.Maps.Route
{
    /// <summary> The Route service client. </summary>
    public partial class MapsRouteClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        private readonly HttpPipeline _pipeline;

        /// <summary> The RestClient is used to access Route REST client. </summary>
        internal RouteRestClient RestClient { get; }

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics _clientDiagnostics { get; }

        /// <summary> Initializes a new instance of MapsRouteClient. </summary>
        protected MapsRouteClient()
        {
            _clientDiagnostics = null;
            _pipeline = null;
            RestClient = null;
        }

        /// <summary> Initializes a new instance of MapsRouteClient. </summary>
        /// <param name="credential"> Shared key credential used to authenticate to an Azure Maps Route Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public MapsRouteClient(AzureKeyCredential credential)
        {
            Argument.AssertNotNull(credential, nameof(credential));

            var endpoint = new Uri("https://atlas.microsoft.com");
            var options = new MapsRouteClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = HttpPipelineBuilder.Build(options, new AzureKeyCredentialPolicy(credential, "subscription-key"));
            RestClient = new RouteRestClient(_clientDiagnostics, _pipeline, endpoint, null, options.Version);
        }

        /// <summary> Initializes a new instance of MapsRouteClient. </summary>
        /// <param name="credential"> Shared key credential used to authenticate to an Azure Maps Route Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public MapsRouteClient(AzureKeyCredential credential, MapsRouteClientOptions options)
        {
            Argument.AssertNotNull(credential, nameof(credential));

            var endpoint = options.Endpoint;
            options ??= new MapsRouteClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = HttpPipelineBuilder.Build(options, new AzureKeyCredentialPolicy(credential, "subscription-key"));
            RestClient = new RouteRestClient(_clientDiagnostics, _pipeline, endpoint, null, options.Version);
        }

        /// <summary> Initializes a new instance of MapsRouteClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Maps Route Service. </param>
        /// <param name="clientId"> Specifies which account is intended for usage in conjunction with the Azure AD security model.  It represents a unique ID for the Azure Maps account and can be retrieved from the Azure Maps management  plane Account API. To use Azure AD security in Azure Maps see the following <see href="https://aka.ms/amauthdetails">articles</see> for guidance. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> or <paramref name="clientId"/> is null. </exception>
        public MapsRouteClient(TokenCredential credential, string clientId)
        {
            Argument.AssertNotNull(credential, nameof(credential));

            var endpoint = new Uri("https://atlas.microsoft.com");
            var options = new MapsRouteClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://atlas.microsoft.com/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes), new AzureKeyCredentialPolicy(new AzureKeyCredential(clientId), "x-ms-client-id"));
            RestClient = new RouteRestClient(_clientDiagnostics, _pipeline, endpoint, clientId, options.Version);
        }

        /// <summary> Initializes a new instance of MapsRouteClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Maps Route Service. </param>
        /// <param name="clientId"> Specifies which account is intended for usage in conjunction with the Azure AD security model.  It represents a unique ID for the Azure Maps account and can be retrieved from the Azure Maps management  plane Account API. To use Azure AD security in Azure Maps see the following <see href="https://aka.ms/amauthdetails">articles</see> for guidance. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> or <paramref name="clientId"/> is null. </exception>
        public MapsRouteClient(TokenCredential credential, string clientId, MapsRouteClientOptions options)
        {
            Argument.AssertNotNull(credential, nameof(credential));

            var endpoint = new Uri("https://atlas.microsoft.com");
            options ??= new MapsRouteClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://atlas.microsoft.com/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes), new AzureKeyCredentialPolicy(new AzureKeyCredential(clientId), "x-ms-client-id"));
            RestClient = new RouteRestClient(_clientDiagnostics, _pipeline, endpoint, clientId, options.Version);
        }

        /// <summary>
        /// The Matrix Routing service allows calculation of a matrix of route summaries for a set of routes defined by origin and destination locations by using an asynchronous (async) or synchronous (sync) POST request. For every given origin, the service calculates the cost of routing from that origin to every given destination. The set of origins and the set of destinations can be thought of as the column and row headers of a table and each cell in the table contains the costs of routing from the origin to the destination for that cell. As an example, let&apos;s say a food delivery company has 20 drivers and they need to find the closest driver to pick up the delivery from the restaurant. To solve this use case, they can call Matrix Route API.
        /// For each route, the travel times and distances are returned. You can use the computed costs to determine which detailed routes to calculate using the Route Directions API.
        /// The maximum size of a matrix for sync request is **100** (the number of origins multiplied by the number of destinations).
        /// </summary>
        /// <param name="routeMatrixQuery"> The route matrix to query. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeMatrixQuery"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual async Task<Response<RouteMatrixResult>> SyncRequestRouteMatrixAsync(RouteMatrixQuery routeMatrixQuery, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MapsRouteClient.SyncRequestRouteMatrix");
            scope.Start();
            try
            {
                var options = new RouteMatrixOptions(routeMatrixQuery);
                return await RestClient.RequestRouteMatrixSyncAsync(
                    options.Query,
                    JsonFormat.Json,
                    options?.WaitForResults,
                    options?.ComputeTravelTime,
                    options?.SectionFilter,
                    options?.ArriveAt,
                    options?.DepartAt,
                    options?.VehicleAxleWeightInKilograms,
                    options?.VehicleLengthInMeters,
                    options?.VehicleHeightInMeters,
                    options?.VehicleWidthInMeters,
                    options?.VehicleMaxSpeedInKmPerHour,
                    options?.VehicleWeightInKilograms,
                    options?.Windingness,
                    options?.InclineLevel,
                    options?.TravelMode,
                    options?.Avoid,
                    options?.UseTrafficData,
                    options?.RouteType,
                    options?.VehicleLoadType,
                    cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The Matrix Routing service allows calculation of a matrix of route summaries for a set of routes defined by origin and destination locations by using an asynchronous (async) or synchronous (sync) POST request. For every given origin, the service calculates the cost of routing from that origin to every given destination. The set of origins and the set of destinations can be thought of as the column and row headers of a table and each cell in the table contains the costs of routing from the origin to the destination for that cell. As an example, let&apos;s say a food delivery company has 20 drivers and they need to find the closest driver to pick up the delivery from the restaurant. To solve this use case, they can call Matrix Route API.
        /// For each route, the travel times and distances are returned. You can use the computed costs to determine which detailed routes to calculate using the Route Directions API.
        /// The maximum size of a matrix for sync request is **100** (the number of origins multiplied by the number of destinations).
        /// </summary>
        /// <param name="options"> The route direction options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual async Task<Response<RouteMatrixResult>> SyncRequestRouteMatrixAsync(RouteMatrixOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(options, nameof(options));

            using var scope = _clientDiagnostics.CreateScope("MapsRouteClient.SyncRequestRouteMatrix");
            scope.Start();
            try
            {
                return await RestClient.RequestRouteMatrixSyncAsync(
                    options.Query,
                    JsonFormat.Json,
                    options?.WaitForResults,
                    options?.ComputeTravelTime,
                    options?.SectionFilter,
                    options?.ArriveAt,
                    options?.DepartAt,
                    options?.VehicleAxleWeightInKilograms,
                    options?.VehicleLengthInMeters,
                    options?.VehicleHeightInMeters,
                    options?.VehicleWidthInMeters,
                    options?.VehicleMaxSpeedInKmPerHour,
                    options?.VehicleWeightInKilograms,
                    options?.Windingness,
                    options?.InclineLevel,
                    options?.TravelMode,
                    options?.Avoid,
                    options?.UseTrafficData,
                    options?.RouteType,
                    options?.VehicleLoadType,
                    cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The Matrix Routing service allows calculation of a matrix of route summaries for a set of routes defined by origin and destination locations by using an asynchronous (async) or synchronous (sync) POST request. For every given origin, the service calculates the cost of routing from that origin to every given destination. The set of origins and the set of destinations can be thought of as the column and row headers of a table and each cell in the table contains the costs of routing from the origin to the destination for that cell. As an example, let&apos;s say a food delivery company has 20 drivers and they need to find the closest driver to pick up the delivery from the restaurant. To solve this use case, they can call Matrix Route API.
        /// For each route, the travel times and distances are returned. You can use the computed costs to determine which detailed routes to calculate using the Route Directions API.
        /// The maximum size of a matrix for sync request is **100** (the number of origins multiplied by the number of destinations).
        /// </summary>
        /// <param name="routeMatrixQuery"> The route matrix to query. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeMatrixQuery"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual Response<RouteMatrixResult> SyncRequestRouteMatrix(RouteMatrixQuery routeMatrixQuery, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MapsRouteClient.SyncRequestRouteMatrix");
            scope.Start();
            try
            {
                var options = new RouteMatrixOptions(routeMatrixQuery);
                return RestClient.RequestRouteMatrixSync(
                    options.Query,
                    JsonFormat.Json,
                    options?.WaitForResults,
                    options?.ComputeTravelTime,
                    options?.SectionFilter,
                    options?.ArriveAt,
                    options?.DepartAt,
                    options?.VehicleAxleWeightInKilograms,
                    options?.VehicleLengthInMeters,
                    options?.VehicleHeightInMeters,
                    options?.VehicleWidthInMeters,
                    options?.VehicleMaxSpeedInKmPerHour,
                    options?.VehicleWeightInKilograms,
                    options?.Windingness,
                    options?.InclineLevel,
                    options?.TravelMode,
                    options?.Avoid,
                    options?.UseTrafficData,
                    options?.RouteType,
                    options?.VehicleLoadType,
                    cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The Matrix Routing service allows calculation of a matrix of route summaries for a set of routes defined by origin and destination locations by using an asynchronous (async) or synchronous (sync) POST request. For every given origin, the service calculates the cost of routing from that origin to every given destination. The set of origins and the set of destinations can be thought of as the column and row headers of a table and each cell in the table contains the costs of routing from the origin to the destination for that cell. As an example, let&apos;s say a food delivery company has 20 drivers and they need to find the closest driver to pick up the delivery from the restaurant. To solve this use case, they can call Matrix Route API.
        /// For each route, the travel times and distances are returned. You can use the computed costs to determine which detailed routes to calculate using the Route Directions API.
        /// The maximum size of a matrix for sync request is **100** (the number of origins multiplied by the number of destinations).
        /// </summary>
        /// <param name="options"> The route direction options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual Response<RouteMatrixResult> SyncRequestRouteMatrix(RouteMatrixOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(options, nameof(options));

            using var scope = _clientDiagnostics.CreateScope("MapsRouteClient.SyncRequestRouteMatrix");
            scope.Start();
            try
            {
                return RestClient.RequestRouteMatrixSync(
                    options.Query,
                    JsonFormat.Json,
                    options?.WaitForResults,
                    options?.ComputeTravelTime,
                    options?.SectionFilter,
                    options?.ArriveAt,
                    options?.DepartAt,
                    options?.VehicleAxleWeightInKilograms,
                    options?.VehicleLengthInMeters,
                    options?.VehicleHeightInMeters,
                    options?.VehicleWidthInMeters,
                    options?.VehicleMaxSpeedInKmPerHour,
                    options?.VehicleWeightInKilograms,
                    options?.Windingness,
                    options?.InclineLevel,
                    options?.TravelMode,
                    options?.Avoid,
                    options?.UseTrafficData,
                    options?.RouteType,
                    options?.VehicleLoadType,
                    cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns  a route between an origin and a destination, passing through waypoints if they are specified. The route will take into account factors such as current traffic and the typical road speeds on the requested day of the week and time of day.
        ///
        /// Information returned includes the distance, estimated travel time, and a representation of the route geometry. Additional routing information such as optimized waypoint order or turn by turn instructions is also available, depending on the options selected.
        ///
        /// Routing service provides a set of parameters for a detailed description of vehicle-specific Consumption Model. Please check <see href="https://docs.microsoft.com/azure/azure-maps/consumption-model">Consumption Model</see> for detailed explanation of the concepts and parameters involved.
        /// </summary>
        /// <param name="routeDirectionQuery"> The route direction query, including a list of route points and route direction options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeDirectionQuery"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual async Task<Response<RouteDirections>> GetDirectionsAsync(RouteDirectionQuery routeDirectionQuery, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(routeDirectionQuery, nameof(routeDirectionQuery));

            using var scope = _clientDiagnostics.CreateScope("MapsRouteClient.GetDirections");
            scope.Start();
            try
            {
                var stringRoutePoints = MapsRouteClient.geoPointsToString(routeDirectionQuery.RoutePoints);
                var options = routeDirectionQuery.RouteDirectionOptions;

                if (options?.RouteDirectionParameters == null)
                {
                    return await RestClient.GetRouteDirectionsAsync(
                        stringRoutePoints,
                        ResponseFormat.Json,
                        options?.MaxAlternatives,
                        options?.AlternativeType,
                        options?.MinDeviationDistance,
                        options?.ArriveAt,
                        options?.DepartAt,
                        options?.MinDeviationTime,
                        options?.InstructionsType,
                        options?.Language,
                        options?.ComputeBestWaypointOrder,
                        options?.RouteRepresentationForBestOrder,
                        options?.ComputeTravelTime,
                        options?.VehicleHeading,
                        options?.Report,
                        options?.SectionFilter,
                        options?.VehicleAxleWeightInKilograms,
                        options?.VehicleWidthInMeters,
                        options?.VehicleHeightInMeters,
                        options?.VehicleLengthInMeters,
                        options?.VehicleMaxSpeedInKmPerHour,
                        options?.VehicleWeightInKilograms,
                        options?.IsCommercialVehicle,
                        options?.Windingness,
                        options?.InclineLevel,
                        options?.TravelMode,
                        options?.Avoid,
                        options?.UseTrafficData,
                        options?.RouteType,
                        options?.VehicleLoadType,
                        options?.VehicleEngineType,
                        options?.ConstantSpeedConsumptionInLitersPerHundredKm,
                        options?.CurrentFuelInLiters,
                        options?.AuxiliaryPowerInLitersPerHour,
                        options?.FuelEnergyDensityInMegajoulesPerLiter,
                        options?.AccelerationEfficiency,
                        options?.DecelerationEfficiency,
                        options?.UphillEfficiency,
                        options?.DownhillEfficiency,
                        options?.ConstantSpeedConsumptionInKwHPerHundredKm,
                        options?.CurrentChargeInKwH,
                        options?.MaxChargeInKwH,
                        options?.AuxiliaryPowerInKw,
                        cancellationToken
                    ).ConfigureAwait(false);
                }
                else
                {
                    return await RestClient.GetRouteDirectionsWithAdditionalParametersAsync(
                        stringRoutePoints,
                        options.RouteDirectionParameters,
                        ResponseFormat.Json,
                        options?.MaxAlternatives,
                        options?.AlternativeType,
                        options?.MinDeviationDistance,
                        options?.MinDeviationTime,
                        options?.InstructionsType,
                        options?.Language,
                        options?.ComputeBestWaypointOrder,
                        options?.RouteRepresentationForBestOrder,
                        options?.ComputeTravelTime,
                        options?.VehicleHeading,
                        options?.Report,
                        options?.SectionFilter,
                        options?.ArriveAt,
                        options?.DepartAt,
                        options?.VehicleAxleWeightInKilograms,
                        options?.VehicleLengthInMeters,
                        options?.VehicleHeightInMeters,
                        options?.VehicleWidthInMeters,
                        options?.VehicleMaxSpeedInKmPerHour,
                        options?.VehicleWeightInKilograms,
                        options?.IsCommercialVehicle,
                        options?.Windingness,
                        options?.InclineLevel,
                        options?.TravelMode,
                        options?.Avoid,
                        options?.UseTrafficData,
                        options?.RouteType,
                        options?.VehicleLoadType,
                        options?.VehicleEngineType,
                        options?.ConstantSpeedConsumptionInLitersPerHundredKm,
                        options?.CurrentFuelInLiters,
                        options?.AuxiliaryPowerInLitersPerHour,
                        options?.FuelEnergyDensityInMegajoulesPerLiter,
                        options?.AccelerationEfficiency,
                        options?.DecelerationEfficiency,
                        options?.UphillEfficiency,
                        options?.DownhillEfficiency,
                        options?.ConstantSpeedConsumptionInKwHPerHundredKm,
                        options?.CurrentChargeInKwH,
                        options?.MaxChargeInKwH,
                        options?.AuxiliaryPowerInKw,
                        cancellationToken
                    ).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a route between an origin and a destination, passing through waypoints if they are specified. The route will take into account factors such as current traffic and the typical road speeds on the requested day of the week and time of day.
        /// Information returned includes the distance, estimated travel time, and a representation of the route geometry. Additional routing information such as optimized waypoint order or turn by turn instructions is also available, depending on the options selected.
        /// Routing service provides a set of parameters for a detailed description of vehicle-specific Consumption Model. Please check <see href="https://docs.microsoft.com/azure/azure-maps/consumption-model">Consumption Model</see> for detailed explanation of the concepts and parameters involved.
        /// </summary>
        /// <param name="routeDirectionQuery"> The route direction query, including a list of route points and route direction options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeDirectionQuery"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual Response<RouteDirections> GetDirections(RouteDirectionQuery routeDirectionQuery, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(routeDirectionQuery, nameof(routeDirectionQuery));

            using var scope = _clientDiagnostics.CreateScope("MapsRouteClient.GetDirections");
            scope.Start();
            try
            {
                var stringRoutePoints = MapsRouteClient.geoPointsToString(routeDirectionQuery.RoutePoints);
                var options = routeDirectionQuery.RouteDirectionOptions;

                if (options?.RouteDirectionParameters == null)
                {
                    return RestClient.GetRouteDirections(
                        stringRoutePoints,
                        ResponseFormat.Json,
                        options?.MaxAlternatives,
                        options?.AlternativeType,
                        options?.MinDeviationDistance,
                        options?.ArriveAt,
                        options?.DepartAt,
                        options?.MinDeviationTime,
                        options?.InstructionsType,
                        options?.Language,
                        options?.ComputeBestWaypointOrder,
                        options?.RouteRepresentationForBestOrder,
                        options?.ComputeTravelTime,
                        options?.VehicleHeading,
                        options?.Report,
                        options?.SectionFilter,
                        options?.VehicleAxleWeightInKilograms,
                        options?.VehicleWidthInMeters,
                        options?.VehicleHeightInMeters,
                        options?.VehicleLengthInMeters,
                        options?.VehicleMaxSpeedInKmPerHour,
                        options?.VehicleWeightInKilograms,
                        options?.IsCommercialVehicle,
                        options?.Windingness,
                        options?.InclineLevel,
                        options?.TravelMode,
                        options?.Avoid,
                        options?.UseTrafficData,
                        options?.RouteType,
                        options?.VehicleLoadType,
                        options?.VehicleEngineType,
                        options?.ConstantSpeedConsumptionInLitersPerHundredKm,
                        options?.CurrentFuelInLiters,
                        options?.AuxiliaryPowerInLitersPerHour,
                        options?.FuelEnergyDensityInMegajoulesPerLiter,
                        options?.AccelerationEfficiency,
                        options?.DecelerationEfficiency,
                        options?.UphillEfficiency,
                        options?.DownhillEfficiency,
                        options?.ConstantSpeedConsumptionInKwHPerHundredKm,
                        options?.CurrentChargeInKwH,
                        options?.MaxChargeInKwH,
                        options?.AuxiliaryPowerInKw,
                        cancellationToken
                    );
                }
                else
                {
                    return RestClient.GetRouteDirectionsWithAdditionalParameters(
                        stringRoutePoints,
                        options.RouteDirectionParameters,
                        ResponseFormat.Json,
                        options?.MaxAlternatives,
                        options?.AlternativeType,
                        options?.MinDeviationDistance,
                        options?.MinDeviationTime,
                        options?.InstructionsType,
                        options?.Language,
                        options?.ComputeBestWaypointOrder,
                        options?.RouteRepresentationForBestOrder,
                        options?.ComputeTravelTime,
                        options?.VehicleHeading,
                        options?.Report,
                        options?.SectionFilter,
                        options?.ArriveAt,
                        options?.DepartAt,
                        options?.VehicleAxleWeightInKilograms,
                        options?.VehicleLengthInMeters,
                        options?.VehicleHeightInMeters,
                        options?.VehicleWidthInMeters,
                        options?.VehicleMaxSpeedInKmPerHour,
                        options?.VehicleWeightInKilograms,
                        options?.IsCommercialVehicle,
                        options?.Windingness,
                        options?.InclineLevel,
                        options?.TravelMode,
                        options?.Avoid,
                        options?.UseTrafficData,
                        options?.RouteType,
                        options?.VehicleLoadType,
                        options?.VehicleEngineType,
                        options?.ConstantSpeedConsumptionInLitersPerHundredKm,
                        options?.CurrentFuelInLiters,
                        options?.AuxiliaryPowerInLitersPerHour,
                        options?.FuelEnergyDensityInMegajoulesPerLiter,
                        options?.AccelerationEfficiency,
                        options?.DecelerationEfficiency,
                        options?.UphillEfficiency,
                        options?.DownhillEfficiency,
                        options?.ConstantSpeedConsumptionInKwHPerHundredKm,
                        options?.CurrentChargeInKwH,
                        options?.MaxChargeInKwH,
                        options?.AuxiliaryPowerInKw,
                        cancellationToken
                    );
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This service will calculate a set of locations that can be reached from the origin point based on fuel, energy,  time or distance budget that is specified. A polygon boundary (or Isochrone) is returned in a counterclockwise  orientation as well as the precise polygon center which was the result of the origin point.
        /// The returned polygon can be used for further processing such as  <see href="https://docs.microsoft.com/rest/api/maps/search/postsearchinsidegeometry">Search Inside Geometry</see> to  search for POIs within the provided Isochrone.
        /// </summary>
        /// <param name="options"> Route range options to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual async Task<Response<RouteRangeResult>> GetRouteRangeAsync(RouteRangeOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(options, nameof(options));

            using var scope = _clientDiagnostics.CreateScope("MapsRouteClient.GetRouteRange");
            scope.Start();
            try
            {
                return await RestClient.GetRouteRangeAsync(
                    options.Query,
                    ResponseFormat.Json,
                    options.FuelBudgetInLiters,
                    options.EnergyBudgetInKwH,
                    options.TimeBudget?.TotalSeconds,
                    options.DistanceBudgetInMeters,
                    options.DepartAt,
                    options.RouteType,
                    options.UseTrafficData,
                    options.Avoid,
                    options.TravelMode,
                    options.InclineLevel,
                    options.Windingness,
                    options.VehicleAxleWeightInKilograms,
                    options.VehicleWidthInMeters,
                    options.VehicleHeightInMeters,
                    options.VehicleLengthInMeters,
                    options.VehicleMaxSpeedInKmPerHour,
                    options.VehicleWeightInKilograms,
                    options.IsCommercialVehicle,
                    options.VehicleLoadType,
                    options.VehicleEngineType,
                    options.ConstantSpeedConsumptionInLitersPerHundredKm,
                    options.CurrentFuelInLiters,
                    options.AuxiliaryPowerInLitersPerHour,
                    options.FuelEnergyDensityInMegajoulesPerLiter,
                    options.AccelerationEfficiency,
                    options.DecelerationEfficiency,
                    options.UphillEfficiency,
                    options.DownhillEfficiency,
                    options.ConstantSpeedConsumptionInKwHPerHundredKm,
                    options.CurrentChargeInKwH,
                    options.MaxChargeInKwH,
                    options.AuxiliaryPowerInKw,
                    cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This service will calculate a set of locations that can be reached from the origin point based on fuel, energy,  time or distance budget that is specified. A polygon boundary (or Isochrone) is returned in a counterclockwise  orientation as well as the precise polygon center which was the result of the origin point.
        /// The returned polygon can be used for further processing such as <see href="https://docs.microsoft.com/rest/api/maps/search/postsearchinsidegeometry">Search Inside Geometry</see> to  search for POIs within the provided Isochrone.
        /// </summary>
        /// <param name="options"> Route range options to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual Response<RouteRangeResult> GetRouteRange(RouteRangeOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(options, nameof(options));

            using var scope = _clientDiagnostics.CreateScope("MapsRouteClient.GetRouteRange");
            scope.Start();
            try
            {
                return RestClient.GetRouteRange(
                    options.Query,
                    ResponseFormat.Json,
                    options.FuelBudgetInLiters,
                    options.EnergyBudgetInKwH,
                    options.TimeBudget?.TotalSeconds,
                    options.DistanceBudgetInMeters,
                    options.DepartAt,
                    options.RouteType,
                    options.UseTrafficData,
                    options.Avoid,
                    options.TravelMode,
                    options.InclineLevel,
                    options.Windingness,
                    options.VehicleAxleWeightInKilograms,
                    options.VehicleWidthInMeters,
                    options.VehicleHeightInMeters,
                    options.VehicleLengthInMeters,
                    options.VehicleMaxSpeedInKmPerHour,
                    options.VehicleWeightInKilograms,
                    options.IsCommercialVehicle,
                    options.VehicleLoadType,
                    options.VehicleEngineType,
                    options.ConstantSpeedConsumptionInLitersPerHundredKm,
                    options.CurrentFuelInLiters,
                    options.AuxiliaryPowerInLitersPerHour,
                    options.FuelEnergyDensityInMegajoulesPerLiter,
                    options.AccelerationEfficiency,
                    options.DecelerationEfficiency,
                    options.UphillEfficiency,
                    options.DownhillEfficiency,
                    options.ConstantSpeedConsumptionInKwHPerHundredKm,
                    options.CurrentChargeInKwH,
                    options.MaxChargeInKwH,
                    options.AuxiliaryPowerInKw,
                    cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The Route Directions Batch API sends batches of queries to <see href="https://docs.microsoft.com/rest/api/maps/route/getroutedirections">Route Directions API</see> using just a single API call.
        /// You can call Route Directions Batch API to run either asynchronously (async) or synchronously (sync). The sync API up to **100** queries.
        /// </summary>
        /// <param name="routeDirectionQueries"> The list of route directions queries/requests to process. The list can contain 100 queries for sync version and must contain at least 1 query. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeDirectionQueries"/> is null. </exception>
        public virtual async Task<Response<RouteDirectionsBatchResult>> SyncRequestRouteDirectionsBatchAsync(IList<RouteDirectionQuery> routeDirectionQueries, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(routeDirectionQueries, nameof(routeDirectionQueries));

            using var scope = _clientDiagnostics.CreateScope("MapsRouteClient.SyncRequestRouteDirectionsBatch");
            scope.Start();
            try
            {
                var batchItems = MapsRouteClient.routeDirectionsQueriesToBatchItems(routeDirectionQueries);
                return await RestClient.RequestRouteDirectionsBatchSyncAsync(batchItems, null, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The Route Directions Batch API sends batches of queries to <see href="https://docs.microsoft.com/rest/api/maps/route/getroutedirections">Route Directions API</see> using just a single API call.
        /// You can call Route Directions Batch API to run either asynchronously (async) or synchronously (sync). The sync API up to **100** queries.
        /// </summary>
        /// <param name="routeDirectionQueries"> The list of route directions queries/requests to process. The list can contain 100 queries for sync version and must contain at least 1 query. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeDirectionQueries"/> is null. </exception>
        public virtual Response<RouteDirectionsBatchResult> SyncRequestRouteDirectionsBatch(IList<RouteDirectionQuery> routeDirectionQueries, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(routeDirectionQueries, nameof(routeDirectionQueries));

            using var scope = _clientDiagnostics.CreateScope("MapsRouteClient.SyncRequestRouteDirectionsBatch");
            scope.Start();
            try
            {
                var batchItems = MapsRouteClient.routeDirectionsQueriesToBatchItems(routeDirectionQueries);
                return RestClient.RequestRouteDirectionsBatchSync(batchItems, null, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The Matrix Routing service allows calculation of a matrix of route summaries for a set of routes defined by origin and destination locations by using an asynchronous (async) or synchronous (sync) POST request. For every given origin, the service calculates the cost of routing from that origin to every given destination. The set of origins and the set of destinations can be thought of as the column and row headers of a table and each cell in the table contains the costs of routing from the origin to the destination for that cell. As an example, let&apos;s say a food delivery company has 20 drivers and they need to find the closest driver to pick up the delivery from the restaurant. To solve this use case, they can call Matrix Route API.
        /// For each route, the travel times and distances are returned. You can use the computed costs to determine which detailed routes to calculate using the Route Directions API.
        /// The maximum size of a matrix for async request is **700** (the number of origins multiplied by the number of destinations).
        /// </summary>
        /// <param name="options"> The route direction options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual async Task<RequestRouteMatrixOperation> StartRequestRouteMatrixAsync(RouteMatrixOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(options, nameof(options));

            using var scope = _clientDiagnostics.CreateScope("MapsRouteClient.StartRequestRouteMatrix");
            scope.Start();
            try
            {
                var response = await RestClient.RequestRouteMatrixAsync(
                    options.Query,
                    JsonFormat.Json,
                    options?.WaitForResults,
                    options?.ComputeTravelTime,
                    options?.SectionFilter,
                    options?.ArriveAt,
                    options?.DepartAt,
                    options?.VehicleAxleWeightInKilograms,
                    options?.VehicleLengthInMeters,
                    options?.VehicleHeightInMeters,
                    options?.VehicleWidthInMeters,
                    options?.VehicleMaxSpeedInKmPerHour,
                    options?.VehicleWeightInKilograms,
                    options?.Windingness,
                    options?.InclineLevel,
                    options?.TravelMode,
                    options?.Avoid,
                    options?.UseTrafficData,
                    options?.RouteType,
                    options?.VehicleLoadType,
                    cancellationToken
                ).ConfigureAwait(false);
                return new RequestRouteMatrixOperation(
                    this, new Uri(response.Headers.Location)
                );
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The Matrix Routing service allows calculation of a matrix of route summaries for a set of routes defined by origin and destination locations by using an asynchronous (async) or synchronous (sync) POST request. For every given origin, the service calculates the cost of routing from that origin to every given destination. The set of origins and the set of destinations can be thought of as the column and row headers of a table and each cell in the table contains the costs of routing from the origin to the destination for that cell. As an example, let&apos;s say a food delivery company has 20 drivers and they need to find the closest driver to pick up the delivery from the restaurant. To solve this use case, they can call Matrix Route API.
        /// For each route, the travel times and distances are returned. You can use the computed costs to determine which detailed routes to calculate using the Route Directions API.
        /// The maximum size of a matrix for async request is **700** (the number of origins multiplied by the number of destinations).
        /// </summary>
        /// <param name="options"> The route direction options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual RequestRouteMatrixOperation StartRequestRouteMatrix(RouteMatrixOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(options, nameof(options));

            using var scope = _clientDiagnostics.CreateScope("MapsRouteClient.StartRequestRouteMatrix");
            scope.Start();
            try
            {
                var response = RestClient.RequestRouteMatrix(
                    options.Query,
                    JsonFormat.Json,
                    options?.WaitForResults,
                    options?.ComputeTravelTime,
                    options?.SectionFilter,
                    options?.ArriveAt,
                    options?.DepartAt,
                    options?.VehicleAxleWeightInKilograms,
                    options?.VehicleLengthInMeters,
                    options?.VehicleHeightInMeters,
                    options?.VehicleWidthInMeters,
                    options?.VehicleMaxSpeedInKmPerHour,
                    options?.VehicleWeightInKilograms,
                    options?.Windingness,
                    options?.InclineLevel,
                    options?.TravelMode,
                    options?.Avoid,
                    options?.UseTrafficData,
                    options?.RouteType,
                    options?.VehicleLoadType,
                    cancellationToken
                );
                return new RequestRouteMatrixOperation(
                    this, new Uri(response.Headers.Location)
                );
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The Route Directions Batch API sends batches of queries to <see href="https://docs.microsoft.com/rest/api/maps/route/getroutedirections">Route Directions API</see> using just a single API call.
        /// TThis Route Directions Batch API will run asynchronously (async) and it allows caller to batch up to **700** queries.
        /// </summary>
        /// <param name="routeDirectionsQueries"> The list of route directions queries/requests to process. The list can contain a max of 700 queries for async and must contain at least 1 query. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeDirectionsQueries"/> is null. </exception>
        public virtual async Task<RequestRouteDirectionsOperation> StartRequestRouteDirectionsBatchAsync(IList<RouteDirectionQuery> routeDirectionsQueries, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(routeDirectionsQueries, nameof(routeDirectionsQueries));

            using var scope = _clientDiagnostics.CreateScope("MapsRouteClient.StartRequestRouteDirectionsBatch");
            scope.Start();
            try
            {
                var batchItems = MapsRouteClient.routeDirectionsQueriesToBatchItems(routeDirectionsQueries);
                var response = await RestClient.RequestRouteDirectionsBatchAsync(
                    batchItems, null, cancellationToken).ConfigureAwait(false);

                return new RequestRouteDirectionsOperation(
                    this, new Uri(response.Headers.Location)
                );
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The Route Directions Batch API sends batches of queries to <see href="https://docs.microsoft.com/rest/api/maps/route/getroutedirections">Route Directions API</see> using just a single API call.
        /// TThis Route Directions Batch API will run asynchronously (async) and it allows caller to batch up to **700** queries.
        /// </summary>
        /// <param name="routeDirectionsQueries"> The list of route directions queries/requests to process. The list can contain a max of 700 queries for async and must contain at least 1 query. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeDirectionsQueries"/> is null. </exception>
        public virtual RequestRouteDirectionsOperation StartRequestRouteDirectionsBatch(IList<RouteDirectionQuery> routeDirectionsQueries, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(routeDirectionsQueries, nameof(routeDirectionsQueries));

            using var scope = _clientDiagnostics.CreateScope("MapsRouteClient.StartRequestRouteDirectionsBatch");
            scope.Start();
            try
            {
                var batchItems = MapsRouteClient.routeDirectionsQueriesToBatchItems(routeDirectionsQueries);
                var response = RestClient.RequestRouteDirectionsBatch(
                    batchItems, null, cancellationToken);

                return new RequestRouteDirectionsOperation(
                    this, new Uri(response.Headers.Location)
                );
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Convert a list of queries in string format to BatchItems for route directions queries
        /// </summary>
        private static BatchRequest routeDirectionsQueriesToBatchItems(IList<RouteDirectionQuery> routeDirectionsQueries)
        {
            BatchRequest batchItems = new BatchRequest();
            foreach (var query in routeDirectionsQueries)
            {
                var stringRoutePoints = MapsRouteClient.geoPointsToString(query.RoutePoints);
                var options = query.RouteDirectionOptions;
                var uri = new RawRequestUriBuilder();
                uri.AppendQuery("query", stringRoutePoints, false);
                if (options?.ComputeTravelTime != null)
                {
                    uri.AppendQuery("computeTravelTimeFor", options.ComputeTravelTime.Value.ToString(), true);
                }
                if (options?.SectionFilter != null)
                {
                    uri.AppendQuery("sectionType", options.SectionFilter.Value.ToString(), true);
                }
                if (options?.ArriveAt != null)
                {
                    uri.AppendQuery("arriveAt", options.ArriveAt.Value, "O", true);
                }
                if (options?.DepartAt != null)
                {
                    uri.AppendQuery("departAt", options.DepartAt.Value, "O", true);
                }
                if (options?.VehicleAxleWeightInKilograms != null)
                {
                    uri.AppendQuery("vehicleAxleWeight", options.VehicleAxleWeightInKilograms.Value, true);
                }
                if (options?.VehicleLengthInMeters != null)
                {
                    uri.AppendQuery("vehicleLength", options.VehicleLengthInMeters.Value, true);
                }
                if (options?.VehicleHeightInMeters != null)
                {
                    uri.AppendQuery("vehicleHeight", options.VehicleHeightInMeters.Value, true);
                }
                if (options?.VehicleWidthInMeters != null)
                {
                    uri.AppendQuery("vehicleWidth", options.VehicleWidthInMeters.Value, true);
                }
                if (options?.VehicleMaxSpeedInKmPerHour != null)
                {
                    uri.AppendQuery("vehicleMaxSpeed", options.VehicleMaxSpeedInKmPerHour.Value, true);
                }
                if (options?.VehicleWeightInKilograms != null)
                {
                    uri.AppendQuery("vehicleWeight", options.VehicleWeightInKilograms.Value, true);
                }
                if (options?.Windingness != null)
                {
                    uri.AppendQuery("windingness", options.Windingness.Value.ToString(), true);
                }
                if (options?.InclineLevel != null)
                {
                    uri.AppendQuery("hilliness", options.InclineLevel.Value.ToString(), true);
                }
                if (options?.TravelMode != null)
                {
                    uri.AppendQuery("travelMode", options.TravelMode.Value.ToString(), true);
                }
                if (options?.Avoid != null)
                {
                    foreach (var param in options.Avoid)
                    {
                        uri.AppendQuery("avoid", param.ToString(), true);
                    }
                }
                if (options?.UseTrafficData != null)
                {
                    uri.AppendQuery("traffic", options.UseTrafficData.Value, true);
                }
                if (options?.RouteType != null)
                {
                    uri.AppendQuery("routeType", options.RouteType.Value.ToString(), true);
                }
                if (options?.VehicleLoadType != null)
                {
                    uri.AppendQuery("vehicleLoadType", options.VehicleLoadType.Value.ToString(), true);
                }
                batchItems.BatchItems.Add(new BatchRequestItem(uri.Query));
            }
            return batchItems;
        }

        /// <summary>
        /// Convert GeoPosition to a route point string in `{Latitude1},{Longitude1}:{Latitude2},{Longitude2}:...` format
        /// </summary>
        private static string geoPointsToString(IList<GeoPosition> routePoints)
        {
            var sb = new StringBuilder(string.Empty, routePoints.Count * 16);
            foreach (var point in routePoints)
            {
                if (sb.Length > 0)
                {
                    sb.Append(':');
                }
                sb.AppendFormat(CultureInfo.InvariantCulture, "{0},{1}", point.Latitude, point.Longitude);
            }
            return sb.ToString();
        }
    }
}
