/******************************************************************************
 * Copyright (C) Leap Motion, Inc. 2011-2017.                                 *
 * Leap Motion proprietary and  confidential.                                 *
 *                                                                            *
 * Use subject to the terms of the Leap Motion SDK Agreement available at     *
 * https://developer.leapmotion.com/sdk_agreement, or another agreement       *
 * between Leap Motion and you, your company or other organization.           *
 ******************************************************************************/

using UnityEngine;
using System.Collections.Generic;

namespace Leap.Unity {

  /// <summary>
  /// A simple wrapper around List to provide readonly access.
  /// Useful when you want to return a list to someone but you want
  /// to make sure they don't muck it up!
  /// </summary>
  public struct ReadonlyList<T> {
    private readonly List<T> _list;

    public ReadonlyList(List<T> list) {
      _list = list;
    }

    public int Count {
      get {
        return _list.Count;
      }
    }

    public T this[int index] {
      get {
        return _list[index];
      }
    }

    public static implicit operator ReadonlyList<T>(List<T> list) {
      return new ReadonlyList<T>(list);
    }
  }
}
