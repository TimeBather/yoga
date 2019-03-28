/**
 * Copyright (c) Facebook, Inc. and its affiliates.
 *
 * This source code is licensed under the MIT license found in the LICENSE
 * file in the root directory of this source tree.
 */

// @Generated by gentest/gentest.rb from gentest/fixtures/YGAlignSelfTest.html

using System;
using NUnit.Framework;

namespace Facebook.Yoga
{
    [TestFixture]
    public class YGAlignSelfTest
    {
        [Test]
        public void Test_align_self_center()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.AlignSelf = YogaAlign.Center;
            root_child0.Width = 10;
            root_child0.Height = 10;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(45f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(45f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_align_self_flex_end()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.AlignSelf = YogaAlign.FlexEnd;
            root_child0.Width = 10;
            root_child0.Height = 10;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(90f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_align_self_flex_start()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.AlignSelf = YogaAlign.FlexStart;
            root_child0.Width = 10;
            root_child0.Height = 10;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(90f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_align_self_flex_end_override_flex_start()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.AlignItems = YogaAlign.FlexStart;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.AlignSelf = YogaAlign.FlexEnd;
            root_child0.Width = 10;
            root_child0.Height = 10;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(90f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_align_self_baseline()
        {
            YogaConfig config = new YogaConfig();

            YogaNode root = new YogaNode(config);
            root.FlexDirection = YogaFlexDirection.Row;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode(config);
            root_child0.AlignSelf = YogaAlign.Baseline;
            root_child0.Width = 50;
            root_child0.Height = 50;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode(config);
            root_child1.AlignSelf = YogaAlign.Baseline;
            root_child1.Width = 50;
            root_child1.Height = 20;
            root.Insert(1, root_child1);

            YogaNode root_child1_child0 = new YogaNode(config);
            root_child1_child0.Width = 50;
            root_child1_child0.Height = 10;
            root_child1.Insert(0, root_child1_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(50f, root_child1.LayoutX);
            Assert.AreEqual(40f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child1_child0.LayoutX);
            Assert.AreEqual(0f, root_child1_child0.LayoutY);
            Assert.AreEqual(50f, root_child1_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child1_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(50f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(40f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child1_child0.LayoutX);
            Assert.AreEqual(0f, root_child1_child0.LayoutY);
            Assert.AreEqual(50f, root_child1_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child1_child0.LayoutHeight);
        }

    }
}
