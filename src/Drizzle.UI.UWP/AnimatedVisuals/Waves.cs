﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//       LottieGen version:
//           7.1.1+g046e9eb0a2
//       
//       Command:
//           LottieGen -Language CSharp -Public -WinUIVersion 2.4 -InputFile Animation - 1700918320604.json
//       
//       Input file:
//           Animation - 1700918320604.json (4532 bytes created 18:49+05:30 Nov 25 2023)
//       
//       LottieGen source:
//           http://aka.ms/Lottie
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// ____________________________________
// |       Object stats       | Count |
// |__________________________|_______|
// | All CompositionObjects   |    56 |
// |--------------------------+-------|
// | Expression animators     |    12 |
// | KeyFrame animators       |     6 |
// | Reference parameters     |    12 |
// | Expression operations    |    12 |
// |--------------------------+-------|
// | Animated brushes         |     - |
// | Animated gradient stops  |     - |
// | ExpressionAnimations     |     7 |
// | PathKeyFrameAnimations   |     - |
// |--------------------------+-------|
// | ContainerVisuals         |     1 |
// | ShapeVisuals             |     1 |
// |--------------------------+-------|
// | ContainerShapes          |     - |
// | CompositionSpriteShapes  |     3 |
// |--------------------------+-------|
// | Brushes                  |     1 |
// | Gradient stops           |     - |
// | CompositionVisualSurface |     - |
// ------------------------------------
using System;
using System.Collections.Generic;
using System.Numerics;
using Windows.UI;
using Windows.UI.Composition;

namespace Drizzle.UI.UWP.AnimatedVisuals
{
    // Name:        SoundBar
    // Frame rate:  60 fps
    // Frame count: 75
    // Duration:    1250.0 mS
    sealed class Waves
        : Microsoft.UI.Xaml.Controls.IAnimatedVisualSource
    {
        // Animation duration: 1.250 seconds.
        internal const long c_durationTicks = 12500000;

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor)
        {
            object ignored = null;
            return TryCreateAnimatedVisual(compositor, out ignored);
        }

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor, out object diagnostics)
        {
            diagnostics = null;

            if (Animation__1700918320604_AnimatedVisual.IsRuntimeCompatible())
            {
                var res = 
                    new Animation__1700918320604_AnimatedVisual(
                        compositor
                        );
                    return res;
            }

            return null;
        }

        /// <summary>
        /// Gets the number of frames in the animation.
        /// </summary>
        public double FrameCount => 75d;

        /// <summary>
        /// Gets the frame rate of the animation.
        /// </summary>
        public double Framerate => 60d;

        /// <summary>
        /// Gets the duration of the animation.
        /// </summary>
        public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);

        /// <summary>
        /// Converts a zero-based frame number to the corresponding progress value denoting the
        /// start of the frame.
        /// </summary>
        public double FrameToProgress(double frameNumber)
        {
            return frameNumber / 75d;
        }

        /// <summary>
        /// Returns a map from marker names to corresponding progress values.
        /// </summary>
        public IReadOnlyDictionary<string, double> Markers =>
            new Dictionary<string, double>
            {
            };

        /// <summary>
        /// Sets the color property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetColorProperty(string propertyName, Color value)
        {
        }

        /// <summary>
        /// Sets the scalar property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetScalarProperty(string propertyName, double value)
        {
        }

        sealed class Animation__1700918320604_AnimatedVisual : Microsoft.UI.Xaml.Controls.IAnimatedVisual
        {
            const long c_durationTicks = 12500000;
            readonly Compositor _c;
            readonly ExpressionAnimation _reusableExpressionAnimation;
            CompositionColorBrush _colorBrush_AlmostBlack_FF111111;
            ContainerVisual _root;
            CubicBezierEasingFunction _cubicBezierEasingFunction_0;
            CubicBezierEasingFunction _cubicBezierEasingFunction_1;
            ExpressionAnimation _rootProgress;
            ScalarKeyFrameAnimation _sizeXScalarAnimation_18_to_18;
            ScalarKeyFrameAnimation _sizeYScalarAnimation_18_to_18_0;
            StepEasingFunction _holdThenStepEasingFunction;

            static void StartProgressBoundAnimation(
                CompositionObject target,
                string animatedPropertyName,
                CompositionAnimation animation,
                ExpressionAnimation controllerProgressExpression)
            {
                target.StartAnimation(animatedPropertyName, animation);
                var controller = target.TryGetAnimationController(animatedPropertyName);
                controller.Pause();
                controller.StartAnimation("Progress", controllerProgressExpression);
            }

            void BindProperty(
                CompositionObject target,
                string animatedPropertyName,
                string expression,
                string referenceParameterName,
                CompositionObject referencedObject)
            {
                _reusableExpressionAnimation.ClearAllParameters();
                _reusableExpressionAnimation.Expression = expression;
                _reusableExpressionAnimation.SetReferenceParameter(referenceParameterName, referencedObject);
                target.StartAnimation(animatedPropertyName, _reusableExpressionAnimation);
            }

            ScalarKeyFrameAnimation CreateScalarKeyFrameAnimation(float initialProgress, float initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateScalarKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            CompositionSpriteShape CreateSpriteShape(CompositionGeometry geometry, Matrix3x2 transformMatrix, CompositionBrush fillBrush)
            {
                var result = _c.CreateSpriteShape(geometry);
                result.TransformMatrix = transformMatrix;
                result.FillBrush = fillBrush;
                return result;
            }

            CompositionColorBrush ColorBrush_AlmostBlack_FF111111()
            {
                return _colorBrush_AlmostBlack_FF111111 = _c.CreateColorBrush(Color.FromArgb(0xFF, 0xff, 0xff, 0xff));
            }

            // Rectangle Path 1.RectangleGeometry
            CompositionRoundedRectangleGeometry RoundedRectangle_0()
            {
                var result = _c.CreateRoundedRectangleGeometry();
                result.CornerRadius = new Vector2(0F, 0F);
                result.Offset = new Vector2(-9F, -9F);
                BindProperty(result, "CornerRadius", "Vector2(Min(20,(Min(my.Size.X,my.Size.Y)/2)),Min(20,(Min(my.Size.X,my.Size.Y)/2)))", "my", result);
                StartProgressBoundAnimation(result, "Size.X", SizeXScalarAnimation_18_to_18(), RootProgress());
                StartProgressBoundAnimation(result, "Size.Y", SizeYScalarAnimation_18_to_18_0(), _rootProgress);
                BindProperty(result, "Offset", "Vector2(0,0)-(my.Size/Vector2(2,2))", "my", result);
                return result;
            }

            // Rectangle Path 1.RectangleGeometry
            CompositionRoundedRectangleGeometry RoundedRectangle_1()
            {
                var result = _c.CreateRoundedRectangleGeometry();
                result.CornerRadius = new Vector2(0F, 0F);
                result.Offset = new Vector2(-9F, -9F);
                BindProperty(result, "CornerRadius", "Vector2(Min(20,(Min(my.Size.X,my.Size.Y)/2)),Min(20,(Min(my.Size.X,my.Size.Y)/2)))", "my", result);
                StartProgressBoundAnimation(result, "Size.X", _sizeXScalarAnimation_18_to_18, _rootProgress);
                StartProgressBoundAnimation(result, "Size.Y", SizeYScalarAnimation_18_to_18_1(), _rootProgress);
                BindProperty(result, "Offset", "Vector2(0,0)-(my.Size/Vector2(2,2))", "my", result);
                return result;
            }

            // Rectangle Path 1.RectangleGeometry
            CompositionRoundedRectangleGeometry RoundedRectangle_2()
            {
                var result = _c.CreateRoundedRectangleGeometry();
                result.CornerRadius = new Vector2(0F, 0F);
                result.Offset = new Vector2(-9F, -9F);
                BindProperty(result, "CornerRadius", "Vector2(Min(20,(Min(my.Size.X,my.Size.Y)/2)),Min(20,(Min(my.Size.X,my.Size.Y)/2)))", "my", result);
                StartProgressBoundAnimation(result, "Size.X", _sizeXScalarAnimation_18_to_18, _rootProgress);
                StartProgressBoundAnimation(result, "Size.Y", _sizeYScalarAnimation_18_to_18_0, _rootProgress);
                BindProperty(result, "Offset", "Vector2(0,0)-(my.Size/Vector2(2,2))", "my", result);
                return result;
            }

            // Layer aggregator
            // Rectangle Path 1
            CompositionSpriteShape SpriteShape_0()
            {
                // Offset:<69.729, 102.856995>
                var geometry = RoundedRectangle_0();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 69.7289963F, 102.856995F), ColorBrush_AlmostBlack_FF111111());;
                return result;
            }

            // Layer aggregator
            // Rectangle Path 1
            CompositionSpriteShape SpriteShape_1()
            {
                // Offset:<97.729, 102.856995>
                var geometry = RoundedRectangle_1();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 97.7289963F, 102.856995F), _colorBrush_AlmostBlack_FF111111);;
                return result;
            }

            // Layer aggregator
            // Rectangle Path 1
            CompositionSpriteShape SpriteShape_2()
            {
                // Offset:<125.604, 102.856995>
                var geometry = RoundedRectangle_2();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 125.603996F, 102.856995F), _colorBrush_AlmostBlack_FF111111);;
                return result;
            }

            // The root of the composition.
            ContainerVisual Root()
            {
                var result = _root = _c.CreateContainerVisual();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Progress", 0F);
                // Layer aggregator
                result.Children.InsertAtTop(ShapeVisual_0());
                return result;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_0()
            {
                return _cubicBezierEasingFunction_0 = _c.CreateCubicBezierEasingFunction(new Vector2(0.400000006F, 0F), new Vector2(0.74000001F, 1F));
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_1()
            {
                return _cubicBezierEasingFunction_1 = _c.CreateCubicBezierEasingFunction(new Vector2(0.400000006F, 0.800000012F), new Vector2(0.74000001F, 1F));
            }

            ExpressionAnimation RootProgress()
            {
                var result = _rootProgress = _c.CreateExpressionAnimation("_.Progress");
                result.SetReferenceParameter("_", _root);
                return result;
            }

            // Size.X
            ScalarKeyFrameAnimation SizeXScalarAnimation_18_to_18()
            {
                // Frame 0.
                var result = _sizeXScalarAnimation_18_to_18 = CreateScalarKeyFrameAnimation(0F, 18F, HoldThenStepEasingFunction());
                // Frame 25.
                result.InsertKeyFrame(0.333333343F, 18F, CubicBezierEasingFunction_0());
                // Frame 50.
                result.InsertKeyFrame(0.666666687F, 18F, _cubicBezierEasingFunction_0);
                // Frame 75.
                result.InsertKeyFrame(1F, 18F, _cubicBezierEasingFunction_0);
                return result;
            }

            // Size.Y
            ScalarKeyFrameAnimation SizeYScalarAnimation_18_to_18_0()
            {
                // Frame 0.
                var result = _sizeYScalarAnimation_18_to_18_0 = CreateScalarKeyFrameAnimation(0F, 18F, _holdThenStepEasingFunction);
                // Frame 25.
                result.InsertKeyFrame(0.333333343F, 36F, CubicBezierEasingFunction_1());
                // Frame 50.
                result.InsertKeyFrame(0.666666687F, 68F, _cubicBezierEasingFunction_1);
                // Frame 75.
                result.InsertKeyFrame(1F, 18F, _cubicBezierEasingFunction_1);
                return result;
            }

            // Rectangle Path 1.RectangleGeometry
            // Size.Y
            ScalarKeyFrameAnimation SizeYScalarAnimation_18_to_18_1()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 18F, _holdThenStepEasingFunction);
                // Frame 25.
                result.InsertKeyFrame(0.333333343F, 68F, _cubicBezierEasingFunction_1);
                // Frame 50.
                result.InsertKeyFrame(0.666666687F, 36F, _cubicBezierEasingFunction_1);
                // Frame 75.
                result.InsertKeyFrame(1F, 18F, _cubicBezierEasingFunction_1);
                return result;
            }

            // Layer aggregator
            ShapeVisual ShapeVisual_0()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(200F, 200F);
                var shapes = result.Shapes;
                // Offset:<145, 160>
                shapes.Add(SpriteShape_0());
                // Offset:<173, 160>
                shapes.Add(SpriteShape_1());
                // Offset:<200.875, 160>
                shapes.Add(SpriteShape_2());
                return result;
            }

            StepEasingFunction HoldThenStepEasingFunction()
            {
                var result = _holdThenStepEasingFunction = _c.CreateStepEasingFunction();
                result.IsFinalStepSingleFrame = true;
                return result;
            }

            internal Animation__1700918320604_AnimatedVisual(
                Compositor compositor
                )
            {
                _c = compositor;
                _reusableExpressionAnimation = compositor.CreateExpressionAnimation();
                Root();
            }

            public Visual RootVisual => _root;
            public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);
            public Vector2 Size => new Vector2(200F, 200F);
            void IDisposable.Dispose() => _root?.Dispose();

            internal static bool IsRuntimeCompatible()
            {
                return Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 7);
            }
        }
    }
}
